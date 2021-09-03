using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class BookingDetails_DTO
    {
        private string IdBooking;

        public string IdBooking
        {
            get { return IdBooking; }
            set { IdBooking = value; }
        }
        private string IdRoom;

        public string IdRoom
        {
            get { return IdRoom; }
            set { IdRoom = value; }
        }
    }
}
