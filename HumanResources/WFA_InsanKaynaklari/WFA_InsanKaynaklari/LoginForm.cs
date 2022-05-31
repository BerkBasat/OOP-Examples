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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string admin = "admin";
        string password = "1234";

      

        private void button2_Click(object sender, EventArgs e)
        {
            string gelenKullaniciAdi = txtKullaniciAdi.Text;
            string gelenSifre = txtSifre.Text;

            if (gelenKullaniciAdi == admin && gelenSifre == password)
            {
                PersonelForm pForm = new PersonelForm();
                pForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgiler Yanlış");
            }
        }
    }
}
