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
    class LoaiPhong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dslp()
        {
            string sql = "Select tenlp From loaiphong";
            return db.getDS(sql);
        }

        public int getTiendatcoc(string tenlp, int sl)
        {
            string sql = "select giaphong from loaiphong where tenlp = '" + tenlp + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            int gia = int.Parse(r[0].ToString());
            return (int)(gia*sl*10/100);
        }

        public int getGiaphong(string tenlp)
        {
            string sql = "select giaphong from loaiphong where tenlp = '" + tenlp + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return (int)r[0];
        }

        public bool truslph(string tenlp)
        {
            string sql = "Update loaiphong set soluong=soluong-1 where tenlp = '" + tenlp + "'";
            return db.ExecuteQuery(sql);
        }

        public bool congslph(string tenlp)
        {
            string sql = "Update loaiphong set soluong=soluong+1 where tenlp = '" + tenlp + "'";
            return db.ExecuteQuery(sql);
        }

        public string slp(string tenlp)
        {
            string sql = "Select soluong from loaiphong where tenlp = '" + tenlp + "'";
            DataTable dtb = new DataTable();
            dtb=db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r[0].ToString();
        }
    }
}
