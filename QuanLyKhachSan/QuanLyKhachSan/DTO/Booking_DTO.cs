using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Booking_DTO
    {
        private string IdBooking;

        public string IdBooking
        {
            get { return IdBooking; }
            set { IdBooking = value; }
        }
        private string IdEmployee;

        public string IdEmployee
        {
            get { return IdEmployee; }
            set { IdEmployee = value; }
        }
        private string IdCustomer;

        public string IdCustomer
        {
            get { return IdCustomer; }
            set { IdCustomer = value; }
        }
        private string RoomName;

        public string RoomName
        {
            get { return RoomName; }
            set { RoomName = value; }
        }
        private DateTime DateBook;

        public DateTime DateBook
        {
            get { return DateBook; }
            set { DateBook = value; }
        }
        private DateTime DateCheckIn;

        public DateTime DateCheckIn
        {
            get { return DateCheckIn; }
            set { DateCheckIn = value; }
        }
        private DateTime DateCheckOut;

        public DateTime DateCheckOut
        {
            get { return DateCheckOut; }
            set { DateCheckOut = value; }
        }
        private int tiendatcoc;

        public int MoneyDeposit
        {
            get { return MoneyDeposit; }
            set { MoneyDeposit = value; }
        }
        private int Quantity;

        public int Quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        private bool status;

        public bool status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
