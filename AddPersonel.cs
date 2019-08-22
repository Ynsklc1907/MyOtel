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
    public partial class AddPersonel : Form
    {
        public AddPersonel()
        {
            id = -1;
            InitializeComponent();
        }

        private int id;

        public AddPersonel(Personel personel)
        {
            id = personel.Id;
            InitializeComponent();

            txtName.Text = personel.Name;
            txtSurname.Text = personel.SurName;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
               Personel  p = new Personel(txtName.Text, txtSurname.Text);
                HotelRepository.personels.Add(p);
            }
            else
            {
                Personel p = HotelRepository.personels.Where(c => c.Id == id).FirstOrDefault();
                p.Name = txtName.Text;
                p.SurName = txtSurname.Text;
            }

            Close();
        }
    }
}
