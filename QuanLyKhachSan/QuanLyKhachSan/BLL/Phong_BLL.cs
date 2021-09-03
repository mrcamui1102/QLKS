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
    class Phong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsph()
        {
            string sql = "Select IdRoom From Room";
            return db.getDS(sql);
        }

        public DataTable dsph(string tenlp)
        {
            string sql = "Select Room.IdRoom From Room, RoomName where Room.tenlp = RoomName.tenlp and RoomName.RoomName = '" + tenlp + "' and Room.status = 'False'";
            return db.getDS(sql);
        }

        public bool capnhatphong(string maphong)
        {
            string sql = "Update Room set status = 1 where IdRoom = '" + maphong + "'";
            return db.ExecuteQuery(sql);
        }

        public bool traphong(string maphong)
        {
            string sql = "Update Room set status = 0 where IdRoom = '" + maphong + "'";
            return db.ExecuteQuery(sql);
        }

        public bool kiemtratinhtrang(string maphong)
        {
            string sql = "select status from Room where IdRoom = '" + maphong + "'";
            DataTable dtb = new DataTable();
            dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            if (r[0].ToString() == "True")
                return true;
            else
                return false;
        }

        public DataTable thongtinphong(string maphong)
        {
            string sql = "Select kh.IdCustomer,kh.NameCustomer,dp.DateCheckIn,dp.DateCheckOut from Customer as kh, Booking as dp, Bookingdetails as ctpd where kh.IdCustomer = dp.IdCustomer and dp.IdBooking = ctpd.IdBooking and ctpd.IdRoom = '" + maphong + "'";
            return db.getDS(sql);
        }
    }
}
