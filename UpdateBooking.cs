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
        public UpdateBooking()
        {
            Initialize();
        }
        public async void Initialize()
        {
            InitializeComponent();
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
                    var cnt = (from c in db.Bookings
                               where c.packageIdFK == item.packageId
                               select c).Count();
                    var bu = new BookingUpdate()
                    {
                        ID = item.packageId,
                        Tier = item.packageTier,
                        Name = item.packageName,
                        IndividualValue = (int)item.packageValue,
                        QuantityBooked = cnt
                    };
                    returnlist.Add(bu);
                }
            }
            return returnlist;
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
