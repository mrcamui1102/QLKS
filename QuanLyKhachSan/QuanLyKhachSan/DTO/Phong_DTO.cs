using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Phong_DTO
    {
        private string maphong;

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        private string telp;

        public string Telp
        {
            get { return telp; }
            set { telp = value; }
        }
        private bool tinhtrang;

        public bool Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
    }
}
