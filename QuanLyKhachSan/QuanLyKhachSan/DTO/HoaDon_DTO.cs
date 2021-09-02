using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class HoaDon_DTO
    {
        private string mahd;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string madp;

        public string Madp
        {
            get { return madp; }
            set { madp = value; }
        }
        private DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        private int tongtien;

        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
    }
}
