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
    public partial class RoomRecordsForm : Form
    {
        public RoomRecordsForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = HotelRepository.roomRecords;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoomRecord frm = new AddRoomRecord();
            frm.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.roomRecords;

        }
    }
}
