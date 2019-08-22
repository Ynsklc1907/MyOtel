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
    public partial class AddRoomRecord : Form
    {
        public AddRoomRecord()
        {
            InitializeComponent();
            comboBoxCustomer.DataSource = HotelRepository.customers;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            RoomRecord rr = new RoomRecord();
            rr.customer = (Customer)comboBoxCustomer.SelectedItem;
            rr.EndDate = dateTimePickerEnd.Value;
            rr.StartDate = dateTimePickerStart.Value;
            rr.room = (Room)dataGridView1.SelectedRows[0].DataBoundItem;
            rr.TotalPrice = Convert.ToDecimal(txtPrice.Text);

            HotelRepository.roomRecords.Add(rr);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            List<Room> avaliableRooms = HotelRepository.rooms.ToList();


            foreach (var item in HotelRepository.roomRecords)
            {
                if(item.StartDate< startDate && item.EndDate>startDate)
                avaliableRooms.Remove(item.room);

                if(item.EndDate>endDate && item.StartDate< endDate)
                    avaliableRooms.Remove(item.room);
                
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = avaliableRooms;

        }
    }
}
