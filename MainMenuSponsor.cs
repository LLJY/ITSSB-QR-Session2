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
    public partial class MainMenuSponsor : Form
    {
        string UserID;
        public MainMenuSponsor(string userid)
        {
            UserID = userid;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LP = new LoginPage();
            LP.Closed += (s, args) => this.Close();
            LP.Show();
        }

        private void book_package_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BP = new BookPackages(UserID);
            BP.Closed += (s, args) => this.Close();
            BP.Show();
        }

        private void Update_package_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BP = new UpdateBooking(UserID);
            BP.Closed += (s, args) => this.Close();
            BP.Show();
        }
    }
}
