using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class RomeName_DTO
    {
        private string RoomName;

        public string RoomName
        {
            get { return RoomName; }
            set { RoomName = value; }
        }
        private int Quantity;

        public int Quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        private int PriceRoom;

        public int PriceRoom
        {
            get { return PriceRoom; }
            set { PriceRoom = value; }
        }
    }
}
