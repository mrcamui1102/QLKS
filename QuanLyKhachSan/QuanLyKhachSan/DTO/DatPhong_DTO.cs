using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class DatPhong_DTO
    {
        private string madp;

        public string Madp
        {
            get { return madp; }
            set { madp = value; }
        }
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenlp;

        public string Tenlp
        {
            get { return tenlp; }
            set { tenlp = value; }
        }
        private DateTime ngaydat;

        public DateTime Ngaydat
        {
            get { return ngaydat; }
            set { ngaydat = value; }
        }
        private DateTime ngayden;

        public DateTime Ngayden
        {
            get { return ngayden; }
            set { ngayden = value; }
        }
        private DateTime ngaydi;

        public DateTime Ngaydi
        {
            get { return ngaydi; }
            set { ngaydi = value; }
        }
        private int tiendatcoc;

        public int Tiendatcoc
        {
            get { return tiendatcoc; }
            set { tiendatcoc = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
