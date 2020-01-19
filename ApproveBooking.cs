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
    public partial class ApproveBooking : Form
    {
        List<BookingApprove> dgvlist;
        public ApproveBooking()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask = GetBookingApproves();
            InitializeComponent();
            dgvlist = await asynctask;
            dataGridView1.DataSource = dgvlist;
        }
        private async void UpdateUI()
        {
            var asynctask = GetBookingApproves();
            dataGridView1.DataSource = null;
            dgvlist = await asynctask;
            dataGridView1.DataSource = dgvlist;
        }
        public async Task<List<BookingApprove>> GetBookingApproves()
        {
            var returnlist = new List<BookingApprove>();
            using(var db = new Session2Entities())
            {
                var query = (from b in db.Bookings
                             select b);
                foreach (var item in query)
                {
                    var ba = new BookingApprove()
                    {
                        ID = item.bookingId,
                        CompanyName = item.User.name,
                        PackageName = item.Package.packageName,
                        Status = item.status
                    };
                    returnlist.Add(ba);
                }
            }
            return returnlist;
        }

        private async void Approve_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var id = dgvlist[dataGridView1.SelectedRows[0].Index].ID;
                var name = dgvlist[dataGridView1.SelectedRows[0].Index].PackageName;
                var booking = (from d in db.Bookings
                               where d.bookingId == id
                               select d).First();
                var package = (from p in db.Packages
                               where p.packageName == name
                               select p).First();
                if (package.packageQuantity >= booking.quantityBooked)
                {
                    package.packageQuantity -= booking.quantityBooked;
                    booking.status = "Approved";
                    await db.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Insufficient quantity");
                }
            }
            UpdateUI();
        }

        private async void Reject_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var id = dgvlist[dataGridView1.SelectedRows[0].Index].ID;
                var booking = (from d in db.Bookings
                               where d.bookingId == id
                               select d).First();
                db.Bookings.Remove(booking);
                booking.status = "Rejected";
                await db.SaveChangesAsync();
            }
            UpdateUI();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MMS = new MainMenuManager();
            MMS.Closed += (s, args) => this.Close();
            MMS.Show();
        }
    }
    public class BookingApprove
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string PackageName { get; set; }
        public string Status { get; set; }
    }
}
