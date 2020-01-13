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
    public partial class ViewPackages : Form
    {
        public ViewPackages()
        {
            Initialize();
        }
        List<SponsorView> defaultlist;
        List<SponsorView> updatelist;
        public async void Initialize()
        {
            var asynctask1 = getPackages();
            InitializeComponent();
            defaultlist = await asynctask1;
            updatelist = defaultlist;
            dataGridView1.DataSource = updatelist;
        }
        private void updateDGV()
        {
            updatelist = defaultlist;
            if (Tier.Checked)
            {
                updatelist = (from a in updatelist
                              orderby a.Tier ascending
                              select a).ToList();
            }
            if (Name.Checked)
            {
                updatelist = (from a in updatelist
                              orderby a.Name ascending
                              select a).ToList();
            }
            if (checkBox3.Checked)
            {
                updatelist = (from a in updatelist
                              orderby a.Value ascending
                              select a).ToList();
            }
            if (checkBox4.Checked)
            {
                updatelist = (from a in updatelist
                              orderby a.AvailableQty descending
                              select a).ToList();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = updatelist;
        }
        public async Task<List<SponsorView>> getPackages()
        {
            var returnlist = new List<SponsorView>();
            using(var db = new Session2Entities())
            {
                var list = (from p in db.Packages
                            join b in db.Benefits on p.packageId equals b.packageIdFK
                            select new { p, b }).ToList();
                foreach (var item in list)
                {
                    try
                    {
                        var exists = (from r in returnlist
                                      where r.ID == item.p.packageId
                                      select r).First();
                        var sp = new SponsorView()
                        {
                            ID = item.p.packageId,
                            Tier = item.p.packageTier,
                            Name = item.p.packageName,
                            Value = item.p.packageValue,
                            AvailableQty = item.p.packageQuantity,
                            Online = item.b.benefitName == "Online" ? "Yes" : "No",
                            Flyer = item.b.benefitName == "Flyer" ? "Yes" : "No",
                            Banner = item.b.benefitName == "Banner" ? "Yes" : "No"
                        };
                        returnlist.Remove(exists);
                        if (exists.Online != sp.Online && exists.Online == "No")
                        {
                            exists.Online = sp.Online;
                        }
                        if (exists.Flyer != sp.Flyer && exists.Flyer == "No")
                        {
                            exists.Flyer = sp.Flyer;
                        }
                        if (exists.Banner != sp.Banner && exists.Banner == "No")
                        {
                            exists.Banner = sp.Banner;
                        }
                        returnlist.Add(exists);
                    }
                    catch
                    {
                        var sp = new SponsorView()
                        {
                            ID = item.p.packageId,
                            Tier = item.p.packageTier,
                            Name = item.p.packageName,
                            Value = item.p.packageValue,
                            AvailableQty = item.p.packageQuantity,
                            Online = item.b.benefitName == "Online" ? "Yes" : "No",
                            Flyer = item.b.benefitName == "Flyer" ? "Yes" : "No",
                            Banner = item.b.benefitName == "Banner" ? "Yes" : "No"
                        };
                        returnlist.Add(sp);
                        
                    }
                }
            }
            return returnlist;
        }

        private void Tier_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void Name_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MMM = new MainMenuManager();
            MMM.Closed += (s, args) => this.Close();
            MMM.Show();
        }
    }
    public class SponsorView
    {
        public int ID { get; set; }
        public string Tier { get; set; }
        public string Name { set; get; }
        public long Value { get; set; }
        public int AvailableQty { get; set; }
        public string Online { get; set; }
        public string Flyer { get; set; }
        public string Banner { get; set; }
    }
}
