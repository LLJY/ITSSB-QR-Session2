using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class UpdateBooking : Form
    {
        List<BookingUpdate> dgvlist = new List<BookingUpdate>();
        string UserID;
        public UpdateBooking(string userid)
        {
            UserID = userid;
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask = GetBookingUpdates();
            InitializeComponent();
            quantity_updown.Minimum = 1;
            dgvlist = await asynctask;
            UpdateUI();

        }
        private void UpdateUI()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dgvlist;
            int total = 0;
            foreach (var item in dgvlist)
            {
                total += item.SubTotalValue;
            }
            total_label.Text = total.ToString();
        }
        /// <summary>
        /// Async method to build the list of BookingUpdates
        /// Count is from counting bookings for every id in packages.
        /// </summary>
        /// <returns></returns>
        private async Task<List<BookingUpdate>> GetBookingUpdates()
        {
            var returnlist = new List<BookingUpdate>();
            using (var db = new Session2Entities())
            {
                var packages = (from p in db.Packages
                                where p.packageQuantity > 0
                                select p).ToList();
                foreach (var item in packages)
                {
                    try
                    {
                        var cnt = (from c in db.Bookings
                                   where c.packageIdFK == item.packageId
                                   where c.userIdFK == UserID
                                   select c.quantityBooked).First();
                        if (cnt > 0)
                        {
                            var bu = new BookingUpdate()
                            {
                                ID = item.packageId,
                                Tier = item.packageTier,
                                Name = item.packageName,
                                IndividualValue = (int)item.packageValue,
                                QuantityBooked = cnt,
                                SubTotalValue = cnt * (int)item.packageValue
                            };
                            returnlist.Add(bu);
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return returnlist;
        }

        private async void Update_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action is irreversible!!", "Are you sure? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var db = new Session2Entities())
                {
                    try
                    {
                        var list = dgvlist[dataGridView1.SelectedRows[0].Index];
                        var item = (from i in db.Packages
                                    where i.packageId == list.ID
                                    select i).First();
                        if (item.packageQuantity < list.QuantityBooked)
                        {
                            MessageBox.Show("Insufficient Quantity!!!");
                        }
                        else
                        {
                            dgvlist[dataGridView1.SelectedRows[0].Index].QuantityBooked = (int)quantity_updown.Value;
                            UpdateUI();
                            var booking = (from c in db.Bookings
                                           where c.packageIdFK == item.packageId
                                           where c.userIdFK == UserID
                                           select c).First();
                            booking.quantityBooked = (int)quantity_updown.Value;
                            await db.SaveChangesAsync();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MMS = new MainMenuSponsor(UserID);
            MMS.Closed += (s, args) => this.Close();
            MMS.Show();
        }

        private async void Delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action is irreversible!!", "Are you sure? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var db = new Session2Entities())
                {
                    try
                    {
                        var list = dgvlist[dataGridView1.SelectedRows[0].Index];
                        var item = (from i in db.Packages
                                    where i.packageId == list.ID
                                    select i).First();
                        var booking = (from c in db.Bookings
                                       where c.packageIdFK == item.packageId
                                       where c.userIdFK == UserID
                                       select c).First();
                        db.Bookings.Remove(booking);
                        await db.SaveChangesAsync();
                    }
                    catch
                    {

                    }
                }
                dgvlist.RemoveAt(dataGridView1.SelectedRows[0].Index);
                UpdateUI();
            }
        }
        public class BookingUpdate
        {
            public int ID { get; set; }
            public string Tier { get; set; }
            public string Name { get; set; }
            public int IndividualValue { get; set; }
            public int QuantityBooked { get; set; }
            public int SubTotalValue { get; set; }
        }
    }
}
