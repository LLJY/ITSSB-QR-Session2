using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Session2
{
    public partial class SponsorshipSummary : Form
    {
        public SponsorshipSummary()
        {
            InitializeComponent();
            comboBox1.Items.Add("None");
            comboBox1.Items.Add("Gold");
            comboBox1.Items.Add("Silver");
            comboBox1.Items.Add("Bronze");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
        private void UpdateUI()
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Legends.Add("Companies");
            chart1.Legends[0].BorderColor = Color.Black;
            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            using (var db = new Session2Entities())
            {
                var bookings = (from b in db.Bookings
                                where b.status == "Approved"
                                select b);
                var allBookings = (from b in db.Bookings
                                   where b.status == "Approved"
                                   group b by new { b.Package.packageName } into c
                                   select new
                                   {
                                       c.Key.packageName,
                                       TotalBooked = c.Sum(a=> a.quantityBooked),
                                       TotalCost = c.Sum(a => a.quantityBooked * a.Package.packageQuantity)
                                   });
                if (comboBox1.SelectedItem.ToString().Equals("None"))
                {
                    //do nothing
                }
                else if (comboBox1.SelectedItem.ToString().Equals("Gold"))
                {
                    allBookings = (from b in db.Bookings
                                       where b.status == "Approved" && b.Package.packageTier == "Gold"
                                       group b by new { b.Package.packageName } into c
                                       select new
                                       {
                                           c.Key.packageName,
                                           TotalBooked = c.Sum(a => a.quantityBooked),
                                           TotalCost = c.Sum(a => a.quantityBooked * a.Package.packageQuantity)
                                       });
                   
                }
                else if (comboBox1.SelectedItem.ToString().Equals("Silver"))
                {
                    allBookings = (from b in db.Bookings
                                       where b.status == "Approved" && b.Package.packageTier == "Silver"
                                       group b by new { b.Package.packageName } into c
                                       select new
                                       {
                                           c.Key.packageName,
                                           TotalBooked = c.Sum(a => a.quantityBooked),
                                           TotalCost = c.Sum(a => a.quantityBooked * a.Package.packageQuantity)
                                       });
                    bookings = (from b in bookings
                                where b.Package.packageTier == "Gold"
                                select b);
                }
                else if (comboBox1.SelectedItem.ToString().Equals("Bronze"))
                {
                    allBookings = (from b in db.Bookings
                                       where b.status == "Approved" && b.Package.packageTier == "Bronze"
                                       group b by new { b.Package.packageName } into c
                                       select new
                                       {
                                           c.Key.packageName,
                                           TotalBooked = c.Sum(a => a.quantityBooked),
                                           TotalCost = c.Sum(a => a.quantityBooked * a.Package.packageQuantity)
                                       });
                    bookings = (from b in bookings
                                where b.Package.packageTier == "Gold"
                                select b);
                }
                int total = 0;
                foreach (var item in allBookings)
                {
                    chart1.Series[0].Points.AddXY(item.packageName, item.TotalBooked);
                    total += item.TotalCost;
                }
                totalvalue_label.Text = total.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MMM = new MainMenuManager();
            MMM.Closed += (s, args) => this.Close();
            MMM.Show();
        }
    }
}
