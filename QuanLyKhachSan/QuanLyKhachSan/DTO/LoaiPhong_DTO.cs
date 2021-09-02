using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class LoaiPhong_DTO
    {
        private string tenlp;

        public string Tenlp
        {
            get { return tenlp; }
            set { tenlp = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private int giaphong;

        public int Giaphong
        {
            get { return giaphong; }
            set { giaphong = value; }
        }
    }
}
