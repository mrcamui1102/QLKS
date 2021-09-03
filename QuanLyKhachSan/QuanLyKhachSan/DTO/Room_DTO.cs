using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class Room_DTO
    {
        private string IdRoom;

        public string IdRoom
        {
            get { return IdRoom; }
            set { IdRoom = value; }
        }
        private string RoomName;

        public string RoomName
        {
            get { return RoomName; }
            set { RoomName = value; }
        }
        private bool status;

        public bool status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
