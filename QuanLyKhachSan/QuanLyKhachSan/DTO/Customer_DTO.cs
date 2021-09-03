using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class KhachHang_DTO
    {
        private string IdCustomer;

        public string IdCustomer
        {
            get { return IdCustomer; }
            set { IdCustomer = value; }
        }
        private string NameCustomer;

        public string NameCustomer
        {
            get { return NameCustomer; }
            set { NameCustomer = value; }
        }
        private string IdCardCustomer;

        public string IdCardCustomer
        {
            get { return IdCardCustomer; }
            set { IdCardCustomer = value; }
        }
        private string PhoneNumber;

        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        private string EmailCustomer;

        public string EmailCustomer
        {
            get { return EmailCustomer; }
            set { EmailCustomer = value; }
        }
        private string diachi;

        public string AddressCustomer
        {
            get { return AddressCustomer; }
            set { AddressCustomer = value; }
        }
    }
}
