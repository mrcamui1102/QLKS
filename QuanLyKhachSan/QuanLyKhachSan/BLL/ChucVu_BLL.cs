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
    class ChucVu_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dscv()
        {
            string sql = "Select * From chucvu";
            return db.getDS(sql);
        }
    }
}
