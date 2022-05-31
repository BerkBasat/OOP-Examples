using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class MenuOlustur : Form
    {
        public MenuOlustur()
        {
            InitializeComponent();
        }

        public static List<Hamburger> hamburgerList = new List<Hamburger>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hamburger hamburger = new Hamburger();
            hamburger.Name = txtMenuAd.Text;
            hamburger.Price = nudMenuFiyat.Value;

            if (txtMenuAd.Text != null || nudMenuFiyat.Value != 0)
            {
                hamburgerList.Add(hamburger);
            }
            else
            {
                MessageBox.Show("Boş Değer Eklenemez!");
            }

            txtMenuAd.Text = "";
            nudMenuFiyat.Value = 0;

            MessageBox.Show("Menu Eklendi!");
        }
    }
}
