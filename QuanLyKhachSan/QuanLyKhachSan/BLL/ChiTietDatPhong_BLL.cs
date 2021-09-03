using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.BLL
{
    class ChiTietDatPhong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsdpct()
        {
            string sql = "Select * From Bookingdetails";
            return db.getDS(sql);
        }

        public DataTable dsdpct(string IdBooking)
        {
            string sql = "Select ct.IdRoom From Bookingdetails as ct, Booking as dp where ct.IdBooking = dp.IdBooking and dp.IdBooking = '" + IdBooking + "'";
            return db.getDS(sql);
        }

        public bool addctdp(BookingDetails_DTO ctdp)
        {
            string[] param = { "@madp", "@maphong" };
            object[] values = { ctdp.IdBooking, ctdp.IdRoom };
            string query = "Insert Into BookingDetails Values(@madp,@maphong)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

    }
}
