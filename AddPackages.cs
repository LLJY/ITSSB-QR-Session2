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
    public partial class AddPackages : Form
    {
        public AddPackages()
        {
            Initialize();
        }
        public async void Initialize()
        {
            InitializeComponent();
            tier_combo.Items.Add("Gold");
            tier_combo.Items.Add("Silver");
            tier_combo.Items.Add("Bronze");
            value_updown.Maximum = 1000000000;
            quantity_updown.Maximum = 1000000000;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //manager
            this.Hide();
            var MMM = new MainMenuManager();
            MMM.Closed += (s, args) => this.Close();
            MMM.Show();
        }

        private async void done_button_Click(object sender, EventArgs e)
        {
            int benefits = 0;
            if (Online.Checked)
            {
                benefits++;
            }
            if (Flyers.Checked)
            {
                benefits++;
            }
            if (Banner.Checked)
            {
                benefits++;
            }
            if (tier_combo.SelectedItem == "Gold")
            {
                if (value_updown.Value >= 50000 && benefits == 3)
                {
                    await addPackage();
                }
                else
                {
                    MessageBox.Show("Package does not meet guidelines");
                }
            }
            if (tier_combo.SelectedItem == "Silver")
            {
                if (value_updown.Value < 50000 && value_updown.Value > 10000 && benefits == 2)
                {
                    await addPackage();
                    
                }
                else
                {
                    MessageBox.Show("Package does not meet guidelines");
                }
            }
            if (tier_combo.SelectedItem == "Bronze")
            {
                {
                    if (value_updown.Value <= 10000 && benefits == 1)
                    {
                        await addPackage();
                        MessageBox.Show("Package does not meet guidelines");
                    }
                    else
                    {
                        MessageBox.Show("Package does not meet guidelines");
                    }
                }
            }
        }
        private async Task addPackage()
        {
            using(var db = new Session2Entities())
            {
                int packageid = (from d in db.Packages
                                 orderby d.packageId descending
                                 select d.packageId).First()+1;
                if (Online.Checked)
                {
                    var benefits = new Benefit()
                    {
                        packageIdFK = packageid,
                        benefitId = (from d in db.Benefits
                                     orderby d.benefitId descending
                                     select d.benefitId).First() + 1,
                        benefitName = "Online"
                    };
                    db.Benefits.Add(benefits);
                }
                if (Flyers.Checked)
                {
                    var benefits = new Benefit()
                    {
                        packageIdFK = packageid,
                        benefitId = (from d in db.Benefits
                                     orderby d.benefitId descending
                                     select d.benefitId).First() + 1,
                        benefitName = "Flyers"
                    };
                    db.Benefits.Add(benefits);
                }
                if (Banner.Checked)
                {
                    var benefits = new Benefit()
                    {
                        packageIdFK = packageid,
                        benefitId = (from d in db.Benefits
                                     orderby d.benefitId descending
                                     select d.benefitId).First() + 1,
                        benefitName = "Banner"
                    };
                    db.Benefits.Add(benefits);
                }

                var pa = new Package()
                {
                    packageId = packageid,
                    packageName = package_box.Text,
                    packageQuantity = (int)quantity_updown.Value,
                    packageTier = tier_combo.SelectedItem.ToString(),
                    packageValue = (int)value_updown.Value
                };
                db.Packages.Add(pa);
                await db.SaveChangesAsync();
            }
        }


        private void clear_button_Click(object sender, EventArgs e)
        {

        }
    }
}
