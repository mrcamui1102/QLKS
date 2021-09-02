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
    class KhachHang_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dskh()
        {
            string sql = "Select * From khachhang";
            return db.getDS(sql);
        }

        public bool addkh(KhachHang_DTO kh)
        {
            string[] param = {"@makh", "@hoten", "@cmnd", "@sdt", "@email", "@diachi" };
            object[] values = {kh.Makh, kh.Hoten, kh.Cmnd, kh.Sdt, kh.Email, kh.Diachi };
            string query = "Insert Into khachhang Values(@makh,@hoten,@cmnd,@sdt,@email,@diachi)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editkh(KhachHang_DTO kh)
        {
            string[] param = { "@makh", "@hoten", "@cmnd", "@sdt", "@email", "@diachi" };
            object[] values = { kh.Makh, kh.Hoten, kh.Cmnd, kh.Sdt, kh.Email, kh.Diachi };
            string query = "Update khachhang Set makh=@makh, hoten=@hoten, cmnd=@cmnd, sdt=@sdt, email=@email, diachi=@diachi Where makh=@makh";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool deletekh(KhachHang_DTO kh)
        {
            string[] param = { "@makh", "@hoten", "@cmnd", "@sdt", "@email", "@diachi" };
            object[] values = { kh.Makh, kh.Hoten, kh.Cmnd, kh.Sdt, kh.Email, kh.Diachi };
            string query = "Delete khachhang Where makh= @makh";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool checkkh(string makh)
        {
            return db.checkExist("khachhang", "makh", makh);
        }
    }
}
