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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();


            dataGridViewPersonel.DataSource = HotelRepository.personels;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("add new Personel",btnAdd,25,25,1000);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPersonel frm = new AddPersonel();
            frm.ShowDialog();

            dataGridViewPersonel.DataSource = null;
            dataGridViewPersonel.DataSource = HotelRepository.personels;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı Seçiniz");
                return;
            }

            Personel p = (Personel)dataGridViewPersonel.SelectedRows[0].DataBoundItem;
            HotelRepository.personels.Remove(p);

            dataGridViewPersonel.DataSource = null;
            dataGridViewPersonel.DataSource = HotelRepository.personels;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Editlenecek satırı Seçiniz");
                return;
            }

            Personel p = (Personel)dataGridViewPersonel.SelectedRows[0].DataBoundItem;

            AddPersonel frm = new AddPersonel(p);
            frm.ShowDialog();

            dataGridViewPersonel.DataSource = null;
            dataGridViewPersonel.DataSource = HotelRepository.personels;
        }
    }
}
