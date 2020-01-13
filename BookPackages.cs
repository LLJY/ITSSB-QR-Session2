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
    public partial class BookPackages : Form
    {
        List<SponsorView> defaultlist;
        List<SponsorView> updatelist;
        String UserID;
        public BookPackages(string userid)
        {
            UserID = userid;
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask1 = getPackages();
            InitializeComponent();
            defaultlist = await asynctask1;
            tier_combo.Items.Add("None");
            tier_combo.Items.Add("Gold");
            tier_combo.Items.Add("Silver");
            tier_combo.Items.Add("Bronze");
            budget_updown.Maximum = 100000;
            updatelist = defaultlist;
            dataGridView1.DataSource = defaultlist;
        }
        public void updateDGV()
        {
            updatelist = defaultlist;
            if (Online.Checked)
            {
                updatelist = (from u in updatelist
                              where u.Online == "Yes"
                              select u).ToList();
            }
            if (Flyers.Checked)
            {
                updatelist = (from u in updatelist
                              where u.Flyer == "Yes"
                              select u).ToList();
            }
            if (Banner.Checked)
            {
                updatelist = (from u in updatelist
                              where u.Banner == "Yes"
                              select u).ToList();
            }
            if(budget_updown.Value > 0)
            {
                updatelist = (from u in updatelist
                              where u.Value <= budget_updown.Value
                              select u).ToList();
            }
            
            //1 Gold
            //2 Silver
            //3 Bronze
            switch (tier_combo.SelectedIndex)
            {
                case 1:
                    updatelist = (from u in updatelist
                                  where u.Tier == "Gold"
                                  select u).ToList();
                    break;
                case 2:
                    updatelist = (from u in updatelist
                                  where u.Tier == "Silver"
                                  select u).ToList();
                    break;
                case 3:
                    updatelist = (from u in updatelist
                                  where u.Tier == "Bronze"
                                  select u).ToList();
                    break;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = updatelist;
                
        }
        public async Task<List<SponsorView>> getPackages()
        {
            var returnlist = new List<SponsorView>();
            using (var db = new Session2Entities())
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

        private void tier_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void budget_updown_ValueChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void Online_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void Flyers_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void Banner_CheckedChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private async void book_button_Click(object sender, EventArgs e)
        {
            if(desired_updown.Value == 0)
            {
                MessageBox.Show("Please select a quantity greater than zero");
            }
            else
            {
                using(var db = new Session2Entities())
                {
                    try
                    {
                        var booking = new Booking()
                        {
                            bookingId = (from b in db.Bookings
                                         orderby b.bookingId descending
                                         select b.bookingId).First() + 1,
                            packageIdFK = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                            userIdFK = UserID,
                            quantityBooked = (int)desired_updown.Value,
                            status = "Pending"
                        };
                        db.Bookings.Add(booking);
                    }
                    catch
                    {
                        var booking = new Booking()
                        {
                            bookingId = 1,
                            packageIdFK = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                            userIdFK = UserID,
                            quantityBooked = (int)desired_updown.Value,
                            status = "Pending"
                        };
                        db.Bookings.Add(booking);
                    }
                    await db.SaveChangesAsync();
                    MessageBox.Show("DONE!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MMS = new MainMenuSponsor(UserID);
            MMS.Closed += (s, args) => this.Close();
            MMS.Show();
        }
    }
}
