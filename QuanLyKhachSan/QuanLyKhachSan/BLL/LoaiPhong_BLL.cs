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
            string sql = "Select RoomName From RoomName";
            return db.getDS(sql);
        }

        public int getTiendatcoc(string tenlp, int sl)
        {
            string sql = "select PriceRoom from RoomName where RoomName = '" + tenlp + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            int gia = int.Parse(r[0].ToString());
            return (int)(gia*sl*10/100);
        }

        public int getGiaphong(string tenlp)
        {
            string sql = "select PriceRoom from RoomName where RoomName = '" + tenlp + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return (int)r[0];
        }

        public bool truslph(string tenlp)
        {
            string sql = "Update RoomName set Quantity=Quantity-1 where RoomName = '" + tenlp + "'";
            return db.ExecuteQuery(sql);
        }

        public bool congslph(string tenlp)
        {
            string sql = "Update RoomName set Quantity=Quantity+1 where RoomName = '" + tenlp + "'";
            return db.ExecuteQuery(sql);
        }

        public string slp(string tenlp)
        {
            string sql = "Select Quantity from RoomName where RoomName = '" + tenlp + "'";
            DataTable dtb = new DataTable();
            dtb=db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r[0].ToString();
        }
    }
}
