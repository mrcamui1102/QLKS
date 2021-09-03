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
    class DatPhong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsdp()
        {
            string sql = "Select * From Booking";
            return db.getDS(sql);
        }

        public bool adddp(Booking_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenlp", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.IdBooking, dp.IdEmployee, dp.IdCustomer, dp.RoomName, dp.DateBook, dp.DateCheckIn, dp.DateCheckOut, dp.MoneyDeposit, dp.Quantity, dp.status };
            string query = "Insert Into Booking Values(@madp,@manv,@makh,@tenlp,convert(date,@ngaydat,105),convert(date,@ngayden,105),convert(date,@ngaydi,105),@tiendatcoc,@soluong,@trangthai)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editdp(Booking_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenlp", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.IdBooking, dp.IdEmployee, dp.IdCustomer, dp.RoomName, dp.DateBook, dp.DateCheckIn, dp.DateCheckOut, dp.MoneyDeposit, dp.Quantity, dp.status };
            string query = "Update Booking set IdBooking=@madp,IdEmployee=@manv,IdCustomer=@makh,RoomName=@tenlp,DateBook=convert(date,@ngaydat,105),DateCheckIn=convert(date,@ngayden,105),DateCheckOut=convert(date,@ngaydi,105),MoneyDeposit=@tiendatcoc,Quantity=@soluong,status=@trangthai where IdBooking=@madp";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool capnhattrangthai(string madp, bool ok)
        {
            string n = "0";
            if(ok)
                n="1";
            string query = "Update Booking set status='" + n+ "' where IdBooking='" + madp+"'";
            return db.ExecuteQuery(query);
        }
    }
}
