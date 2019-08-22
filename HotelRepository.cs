using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOtel
{
    public class HotelRepository
    {
        public static List<Customer> customers;
        public static List<Personel> personels;
        public static List<Room> rooms;
        public static List<RoomRecord> roomRecords;

        public static void populate()
        {
            personels = new List<Personel>();
            customers = new List<Customer>();
            rooms = new List<Room>();
            roomRecords = new List<RoomRecord>();


            Personel p=new Personel("ahmet", "çalışkan");
            personels.Add(p);

            Personel p2 = new Personel("mehmet", "tembel");
            personels.Add(p2);

            Room r = new Room("oda1", 2, 1, p, 200);
            rooms.Add(r);

            Room r1 = new Room("oda2", 2, 1, p, 200);
            rooms.Add(r1);

            Room r2 = new Room("oda3", 2, 1, p, 200);
            rooms.Add(r2);

            Room r3 = new Room("oda4", 2, 1, p, 200);
            rooms.Add(r3);

            Room r4 = new Room("oda5", 3, 2, p2, 300);
            rooms.Add(r4);

            Room r5 = new Room("oda6", 4, 2, p2, 350);
            rooms.Add(r5);

            Room r6 = new Room("oda7", 2, 2, p2, 200);
            rooms.Add(r6);

            Room r7 = new Room("oda8", 2, 2, p2, 200);
            rooms.Add(r7);


            Customer c1 = new Customer("ibrahim", "Yazıcı", "5556677");
            customers.Add(c1);


        }
    }
}
