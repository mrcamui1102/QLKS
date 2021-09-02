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
    class Phong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsph()
        {
            string sql = "Select maphong From phong";
            return db.getDS(sql);
        }

        public DataTable dsph(string tenlp)
        {
            string sql = "Select phong.maphong From phong, loaiphong where phong.tenlp = loaiphong.tenlp and loaiphong.tenlp = '" + tenlp + "' and phong.tinhtrang = 'False'" ;
            return db.getDS(sql);
        }

        public bool capnhatphong(string maphong)
        {
            string sql = "Update phong set tinhtrang = 1 where maphong = '" + maphong + "'";
            return db.ExecuteQuery(sql);
        }

        public bool traphong(string maphong)
        {
            string sql = "Update phong set tinhtrang = 0 where maphong = '" + maphong + "'";
            return db.ExecuteQuery(sql);
        }

        public bool kiemtratinhtrang(string maphong)
        {
            string sql = "select tinhtrang from phong where maphong = '" + maphong + "'";
            DataTable dtb = new DataTable();
            dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            if (r[0].ToString() == "True")
                return true;
            else
                return false;
        }

        public DataTable thongtinphong(string maphong)
        {
            string sql = "Select kh.makh,kh.hoten,dp.ngayden,dp.ngaydi from khachhang as kh, datphong as dp, ctphongdat as ctpd where kh.makh = dp.makh and dp.madp = ctpd.madp and ctpd.maphong = '" + maphong + "'";
            return db.getDS(sql);
        }
    }
}
