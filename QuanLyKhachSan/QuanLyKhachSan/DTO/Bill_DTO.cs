using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Bill_DTO
    {
        private string IdBill;

        public string IdBill
        {
            get { return IdBill; }
            set { IdBill = value; }
        }
        private string IdBooking;

        public string IdBooking
        {
            get { return IdBooking; }
            set { IdBooking = value; }
        }
        private DateTime DateBilling;

        public DateTime DateBilling
        {
            get { return DateBilling; }
            set { DateBilling = value; }
        }
        private int Total;

        public int Total
        {
            get { return Total ; }
            set { Total = value; }
        }
    }
}
