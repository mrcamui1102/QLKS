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
    class Admin_BLL
    {
        DBAccess db = new DBAccess();

        public DataRow infoAdmin(string IdEmployee)
        {
            string sql = "Select nv.IdEmployee, cv.NamePosition, nv.NameEmployee, nv.DateOfBirth, nv.GenderEmployee, nv.PhoneNumber, nv.IdCardEmployee, nv.EmailEmployee, nv.AddressEmployee, pq.Permission, qnv.password " +
                "From Employee as nv, Position as cv, Role as pq, Permission as qnv " +
                "where nv.IdPosition=cv.IdPosition and nv.IdEmployee=qnv.IdEmployee and qnv.Id = pq.Id and nv.IdEmployee = '" + IdEmployee + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r;
        }

        public DataTable dsnvpq()
        {
            string sql = "select IdEmployee from Employee";
            return db.getDS(sql);
        }

        public string quyennv(string IdEmployee)
        {
            string sql = "select pq.Permission from Role as pq, Permission as qnv where qnv.Id=pq.Id and qnv.IdEmployee='" + IdEmployee + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r[0].ToString();
        }
    }
}
