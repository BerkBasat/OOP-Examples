using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_InsanKaynaklari
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanForm dForm = new DepartmanForm();
            dForm.Show();
            this.Hide();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            foreach (Departman departman in DepartmanForm.departmanListesi)
            {
                comboBox1.Items.Add(departman);
            }
        }
    }
}
