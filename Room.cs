using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOtel
{
    public class Room:BaseClass
    {
        
        public Room(string roomNum, int capacity, int floor, Personel resp, decimal price)
        {
            RoomNum = roomNum;
            Capacity = capacity;
            Floor = floor;
            Responsible = resp;
            Price = price;

            maxId++;
            Id = maxId;
        }
       

        public string RoomNum { get; set; }

        public int Capacity { get; set; }

        public int Floor { get; set; }


        public string ResponsibleName
        {
            get
            {
                return Responsible.Name + " " + Responsible.SurName;
            }
        }

        public Personel Responsible { get; set; }

        public decimal Price { get; set; }


    }
}
