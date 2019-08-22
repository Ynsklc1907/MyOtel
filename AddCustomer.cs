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
    public partial class AddCustomer : Form
    {
        int id;
        public AddCustomer()
        {
            id = -1;
            InitializeComponent();
        }

        public AddCustomer(Customer cst)
        {
            id = cst.Id;
            InitializeComponent();

            txtName.Text = cst.Name;
            txtNumber.Text = cst.PhoneNumber;
            txtSurname.Text = cst.Surname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                Customer cst = new Customer(txtName.Text, txtSurname.Text, txtNumber.Text);
                HotelRepository.customers.Add(cst);

            }
            else
            {
                Customer cust = HotelRepository.customers.Where(c => c.Id == id).FirstOrDefault();
                cust.Name = txtName.Text;
                cust.PhoneNumber = txtNumber.Text;
                cust.Surname = txtSurname.Text;
            }
            Close();
        }
    }
}
