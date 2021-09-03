using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Permission_DTO
    {
        private string IdEmployee;

        public string IdEmployee
        {
            get { return IdEmployee; }
            set { IdEmployee = value; }
        }
        private string Id;

        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string password;

        public string password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
