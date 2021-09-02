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
            string sql = "Select * From datphong";
            return db.getDS(sql);
        }

        public bool adddp(DatPhong_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenlp", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.Madp, dp.Manv, dp.Makh, dp.Tenlp, dp.Ngaydat, dp.Ngayden, dp.Ngaydi, dp.Tiendatcoc, dp.Soluong, dp.Trangthai };
            string query = "Insert Into datphong Values(@madp,@manv,@makh,@tenlp,convert(date,@ngaydat,105),convert(date,@ngayden,105),convert(date,@ngaydi,105),@tiendatcoc,@soluong,@trangthai)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editdp(DatPhong_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenlp", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.Madp, dp.Manv, dp.Makh, dp.Tenlp, dp.Ngaydat, dp.Ngayden, dp.Ngaydi, dp.Tiendatcoc, dp.Soluong, dp.Trangthai };
            string query = "Update datphong set madp=@madp,manv=@manv,makh=@makh,tenlp=@tenlp,ngaydat=convert(date,@ngaydat,105),ngayden=convert(date,@ngayden,105),ngaydi=convert(date,@ngaydi,105),tiendatcoc=@tiendatcoc,soluong=@soluong,trangthai=@trangthai where madp=@madp";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool capnhattrangthai(string madp, bool ok)
        {
            string n = "0";
            if(ok)
                n="1";
            string query = "Update datphong set trangthai='"+n+"' where madp='"+madp+"'";
            return db.ExecuteQuery(query);
        }
    }
}
