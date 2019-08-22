using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOtel
{
    public partial class AddRoom : Form
    {
        int id;

        public AddRoom()
        {
            id = -1;
            InitializeComponent();

            comboBox1.DataSource = HotelRepository.personels;
        }

        public AddRoom(Room room)
        {
            id = room.Id;
            
            InitializeComponent();

            txtRoom.Text = room.RoomNum;
            txtCapacity.Text = room.Capacity.ToString();
            txtFloor.Text = room.Floor.ToString();
            txtPrice.Text = room.Price.ToString();

            comboBox1.DataSource = HotelRepository.personels;

            comboBox1.SelectedItem = room.Responsible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string roomNo = txtRoom.Text;
            int capacity = Convert.ToInt32(txtCapacity.Text);
            int floor = Convert.ToInt32(txtFloor.Text);
            Personel resp = (Personel)comboBox1.SelectedItem;

            decimal price = Convert.ToDecimal(txtPrice.Text);

            if (id == -1)
            {
               

                Room r = new Room(roomNo, capacity, floor, resp, price);
                HotelRepository.rooms.Add(r);

            }
            else
            {
                Room r = HotelRepository.rooms.Where(c => c.Id == id).FirstOrDefault();
                r.Floor = floor;
                r.Capacity = capacity;
                r.Price = price;
                r.Responsible = resp;
                r.RoomNum = roomNo;
            }


            Close();
        }
    }
}
