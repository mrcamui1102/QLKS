using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Employee_DTO
    {
        private string IdEmployee;

        public string IdEmployee
        {
            get { return IdEmployee; }
            set { IdEmployee = value; }
        }
        private string IdPosition;

        public string IdPosition
        {
            get { return IdPosition; }
            set { IdPosition = value; }
        }
        private string NameEmployee;

        public string NameEmployee
        {
            get { return NameEmployee; }
            set { NameEmployee = value; }
        }
        private DateTime ngaysinh;

        public DateTime DateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }
        private string GenderEmployee;

        public string GenderEmployee
        {
            get { return GenderEmployee; }
            set { GenderEmployee = value; }
        }
        private string PhoneNumber;

        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        private string IdCardEmployee;

        public string IdCardEmployee
        {
            get { return IdCardEmployee; }
            set { IdCardEmployee = value; }
        }
        private string AddressEmployee;

        public string AddressEmployee
        {
            get { return AddressEmployee; }
            set { AddressEmployee = value; }
        }
        private string EmailEmployee;

        public string EmailEmployee
        {
            get { return EmailEmployee; }
            set { EmailEmployee = value; }
        }

    }
}
