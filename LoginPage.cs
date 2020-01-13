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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AC = new AccountCreation();
            AC.Closed += (s,args) => this.Close();
            AC.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                try
                {
                    var user = (from u in db.Users
                                where u.userId == login_box.Text
                                where u.passwd == password_box.Text
                                select u).First();
                    if (user.userTypeIdFK == 1)
                    {
                        //manager
                        this.Hide();
                        var MMM = new MainMenuManager();
                        MMM.Closed += (s, args) => this.Close();
                        MMM.Show();
                    }
                    else
                    {
                        //Sponsor
                        this.Hide();
                        var MMS = new MainMenuSponsor(login_box.Text);
                        MMS.Closed += (s, args) => this.Close();
                        MMS.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Login");
                }

            }
        }
        
    }
}
