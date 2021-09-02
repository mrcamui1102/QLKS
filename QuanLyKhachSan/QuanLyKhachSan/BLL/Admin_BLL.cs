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

        public DataRow infoAdmin(string manv)
        {
            string sql = "Select nv.manv,cv.tencv,nv.hoten,nv.ngaysinh,nv.gioitinh,nv.sdt,nv.cmnd,nv.email,nv.diachi,pq.quyen,qnv.matkhau From nhanvien as nv, chucvu as cv, phanquyen as pq, quyennv as qnv where nv.macv=cv.macv and nv.manv=qnv.manv and qnv.id = pq.id and nv.manv = '" + manv + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r;
        }

        public DataTable dsnvpq()
        {
            string sql = "select manv from nhanvien";
            return db.getDS(sql);
        }

        public string quyennv(string manv)
        {
            string sql = "select pq.quyen from phanquyen as pq,quyennv as qnv where qnv.id=pq.id and qnv.manv='" + manv + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r[0].ToString();
        }
    }
}
