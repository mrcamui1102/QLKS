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
            string sql = "Select * From Customer";
            return db.getDS(sql);
        }

        public bool addkh(KhachHang_DTO kh)
        {
            string[] param = {"@makh", "@hoten", "@cmnd", "@sdt", "@email", "@diachi" };
            object[] values = {kh.IdCustomer, kh.NameCustomer, kh.IdCardCustomer, kh.PhoneNumber, kh.EmailCustomer, kh.AddressCustomer };
            string query = "Insert Into khachhang Values(@makh,@hoten,@cmnd,@sdt,@email,@diachi)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editkh(KhachHang_DTO kh)
        {
            string[] param = { "@makh", "@hoten", "@cmnd", "@sdt", "@email", "@diachi" };
            object[] values = { kh.IdCustomer, kh.NameCustomer, kh.IdCardCustomer, kh.PhoneNumber, kh.EmailCustomer, kh.AddressCustomer };
            string query = "Update Customer Set IdCustomer=@makh, NameCustomer=@hoten, IdCardCustomer=@cmnd, PhoneNumber=@sdt, EmailCustomer=@email, AddressCustomer=@diachi Where IdCustomer=@makh";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool deletekh(KhachHang_DTO kh)
        {
            string[] param = { "@makh", "@hoten", "@cmnd", "@sdt", "@email", "@diachi" };
            object[] values = { kh.IdCustomer, kh.NameCustomer, kh.IdCardCustomer, kh.PhoneNumber, kh.EmailCustomer, kh.AddressCustomer };
            string query = "Delete Customer Where IdCustomer= @makh";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool checkkh(string makh)
        {
            return db.checkExist("khachhang", "makh", makh);
        }
    }
}
