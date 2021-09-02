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
    class ChiTietDatPhong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsdpct()
        {
            string sql = "Select * From chitietdatphong";
            return db.getDS(sql);
        }

        public DataTable dsdpct(string madp)
        {
            string sql = "Select ct.maphong From ctphongdat as ct, datphong as dp where ct.madp = dp.madp and dp.madp = '" + madp + "'";
            return db.getDS(sql);
        }

        public bool addctdp(CTDP_DTO ctdp)
        {
            string[] param = { "@madp", "@maphong" };
            object[] values = { ctdp.Madp, ctdp.Maphong };
            string query = "Insert Into ctphongdat Values(@madp,@maphong)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

    }
}
