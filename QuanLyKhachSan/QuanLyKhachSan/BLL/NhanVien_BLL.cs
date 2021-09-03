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
            string sql = "Select IdEmployee,NameEmployee,DateOfBirth,GenderEmployee,PhoneNumber,IdCardEmployee,AddressEmployee,EmailEmployee From Employee";
            return db.getDS(sql);
        }

        public DataTable dsnv(string macv)
        {
            string sql = "Select IdEmployee,NameEmployee,DateOfBirth,GenderEmployee,PhoneNumber,IdCardEmployee,AddressEmployee,EmailEmployee From Employee where IdPosition = '" + macv + "'";
            return db.getDS(sql);
        }

        public bool addnv(Employee_DTO nv)
        {
            string[] param = { "@manv", "@macv", "@hoten", "@ngaysinh", "@gioitinh", "@sdt", "@cmnd", "@diachi", "@email" };
            object[] values = { nv.IdEmployee, nv.IdPosition, nv.NameEmployee, nv.DateOfBirth, nv.GenderEmployee, nv.PhoneNumber, nv.IdCardEmployee, nv.AddressEmployee, nv.EmailEmployee };
            string query = "Insert Into Employee Values(@manv,@macv,@hoten,convert(date,@ngaysinh,105),@gioitinh,@sdt,@cmnd,@diachi,@email)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editnv(Employee_DTO nv)
        {
            string[] param = { "@manv", "@macv", "@hoten", "@ngaysinh", "@gioitinh", "@sdt", "@cmnd", "@diachi", "@email" };
            object[] values = { nv.IdEmployee, nv.IdPosition, nv.NameEmployee, nv.DateOfBirth, nv.GenderEmployee, nv.PhoneNumber, nv.IdCardEmployee, nv.AddressEmployee, nv.EmailEmployee };
            string query = "Update Employee Set IdEmployee=@manv, IdPosition=@macv, NameEmployee=@hoten, DateOfBirth=convert(date,@ngaysinh,105), GenderEmployee=@gioitinh, PhoneNumber=@sdt, IdCardEmployee=@cmnd,  AddressEmployee=@diachi, EmailEmployee=@email Where IdEmployee=@manv";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool deletenv(Employee_DTO nv)
        {
            string[] param = { "@manv", "@macv", "@hoten", "@ngaysinh", "@gioitinh", "@sdt", "@cmnd", "@diachi", "@email" };
            object[] values = { nv.IdEmployee, nv.IdPosition, nv.NameEmployee, nv.DateOfBirth, nv.GenderEmployee, nv.PhoneNumber, nv.IdCardEmployee, nv.AddressEmployee, nv.EmailEmployee };
            string query = "Delete Employee Where IdEmployee= @manv";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool checknv(string manv)
        {
            return db.checkExist("nhanvien", "manv", manv);
        }
    }
}
