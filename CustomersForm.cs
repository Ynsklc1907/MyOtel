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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = HotelRepository.customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer frm = new AddCustomer();

            frm.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.customers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seç");
                return;
            }

            Customer cst = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

            AddCustomer frm = new AddCustomer(cst);

            frm.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.customers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seç");
                return;
            }

            Customer cst = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

            HotelRepository.customers.Remove(cst);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = HotelRepository.customers;

        }
    }
}
