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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = HotelRepository.rooms;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoom frm = new AddRoom();
            frm.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.rooms;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Room room = (Room)dataGridView1.SelectedRows[0].DataBoundItem;

                HotelRepository.rooms.Remove(room);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = HotelRepository.rooms;
            }
            else
            {
                MessageBox.Show("Select Row!");
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Room room = (Room)dataGridView1.SelectedRows[0].DataBoundItem;
                AddRoom frm = new AddRoom(room);
                frm.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = HotelRepository.rooms;
                
            }
            else
            {
                MessageBox.Show("Select Row!");
            }
        }

        Room SelectedRoom;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X + 10, Cursor.Position.Y + 10);
                SelectedRoom = (Room)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelRepository.rooms.Remove(SelectedRoom);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.rooms;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddRoom frm = new AddRoom(SelectedRoom);
            frm.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.rooms;
        }
    }
}
