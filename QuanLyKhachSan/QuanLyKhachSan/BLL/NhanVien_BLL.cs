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
    class NhanVien_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsnv()
        {
            string sql = "Select manv,hoten,ngaysinh,gioitinh,sdt,cmnd,diachi,email From nhanvien";
            return db.getDS(sql);
        }

        public DataTable dsnv(string macv)
        {
            string sql = "Select manv,hoten,ngaysinh,gioitinh,sdt,cmnd,diachi,email From nhanvien where macv = '" + macv + "'";
            return db.getDS(sql);
        }

        public bool addnv(NhanVien_DTO nv)
        {
            string[] param = { "@manv", "@macv", "@hoten", "@ngaysinh", "@gioitinh", "@sdt", "@cmnd", "@diachi", "@email" };
            object[] values = { nv.Manv, nv.Macv, nv.Hoten, nv.Ngaysinh, nv.Gioitinh, nv.Sdt, nv.Cmnd, nv.Diachi, nv.Email };
            string query = "Insert Into nhanvien Values(@manv,@macv,@hoten,convert(date,@ngaysinh,105),@gioitinh,@sdt,@cmnd,@diachi,@email)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editnv(NhanVien_DTO nv)
        {
            string[] param = { "@manv", "@macv", "@hoten", "@ngaysinh", "@gioitinh", "@sdt", "@cmnd", "@diachi", "@email" };
            object[] values = { nv.Manv, nv.Macv, nv.Hoten, nv.Ngaysinh, nv.Gioitinh, nv.Sdt, nv.Cmnd, nv.Diachi, nv.Email };
            string query = "Update nhanvien Set manv=@manv, macv=@macv, hoten=@hoten, ngaysinh=convert(date,@ngaysinh,105), gioitinh=@gioitinh, sdt=@sdt, cmnd=@cmnd,  diachi=@diachi, email=@email Where manv=@manv";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool deletenv(NhanVien_DTO nv)
        {
            string[] param = { "@manv", "@macv", "@hoten", "@ngaysinh", "@gioitinh", "@sdt", "@cmnd", "@diachi", "@email" };
            object[] values = { nv.Manv, nv.Macv, nv.Hoten, nv.Ngaysinh, nv.Gioitinh, nv.Sdt, nv.Cmnd, nv.Diachi, nv.Email };
            string query = "Delete nhanvien Where manv= @manv";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool checknv(string manv)
        {
            return db.checkExist("nhanvien", "manv", manv);
        }
    }
}
