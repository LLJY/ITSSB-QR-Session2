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
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        private async void create_button_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(company_box.Text) && string.IsNullOrWhiteSpace(user_box.Text) && string.IsNullOrWhiteSpace(password_box.Text))){
                if (user_box.Text.Length > 8)
                {
                    if (password_box.Text == password_again_box.Text)
                    {
                        await AddUser();
                        MessageBox.Show("DONE!");
                        cancel_button_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!");
                    }
                }
                else
                {
                    MessageBox.Show("UserID must be 8 characters or longer!");
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty");
            }
        }
        private async Task AddUser()
        {
            using (var db = new Session2Entities())
            {
                var user = new User()
                {
                    userId = user_box.Text,
                    name = company_box.Text,
                    passwd = password_box.Text,
                    userTypeIdFK = 2
                };
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LP = new LoginPage();
            LP.Closed += (s, args) => this.Close();
            LP.Show();
        }
    }
}
