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
    public partial class MainMenuManager : Form
    {
        public MainMenuManager()
        {
            InitializeComponent();
        }

        private void view_sponsor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MMM = new ViewPackages();
            MMM.Closed += (s, args) => this.Close();
            MMM.Show();
        }

        private void add_sponsorship_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LP = new AddPackages();
            LP.Closed += (s, args) => this.Close();
            LP.Show();
        }

        private void approve_sponsor_Click(object sender, EventArgs e)
        {

        }

        private void view_sponsor_Click_1(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LP = new LoginPage();
            LP.Closed += (s, args) => this.Close();
            LP.Show();
        }
    }
}
