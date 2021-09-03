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
    class HoaDon_BLL
    {
        DBAccess db = new DBAccess();

        public bool laphoadon(Bill_DTO hd)
        {
            string[] param = { "@mahd", "@madp", "@ngaylap", "@tongtien" };
            object[] values = { hd.IdBill, hd.IdBooking, hd.DateBilling, hd.Total };
            string query = "Insert Into Bill Values(@mahd,@madp,convert(date,@ngaylap,105),@tongtien)";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
