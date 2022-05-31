using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba araba = new Araba();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                araba.Marka = txtMarka.Text;
                araba.Model = txtModel.Text;
                araba.Yıl = Convert.ToInt32(txtUretimYil.Text);
                araba.SaseNo = txtSaseNo.Text;
                araba.MotorGuc = int.Parse(txtMotorGuc.Text);
                araba.YakitTip = cmbYakit.Text;
                araba.VitesTip = cmbVites.Text;
                araba.Kasatip = cmbKasaTip.Text;
                araba.JantBoyut = int.Parse(txtJantBoyut.Text);
                araba.Renk = txtRenk.Text;
                araba.Fiyat = nudFiyat.Value;
                



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            ListViewItem lvi = new ListViewItem();
            lvi.Text = araba.Marka;
            lvi.SubItems.Add(araba.Model);
            lvi.SubItems.Add(araba.Yıl.ToString());
            lvi.SubItems.Add(araba.SaseNo);
            lvi.SubItems.Add(araba.MotorGuc.ToString());
            lvi.SubItems.Add(araba.YakitTip);
            lvi.SubItems.Add(araba.VitesTip);
            lvi.SubItems.Add(araba.JantBoyut.ToString());
            lvi.SubItems.Add(araba.Renk);
            lvi.SubItems.Add(araba.Kasatip);
            lvi.SubItems.Add(araba.Fiyat.ToString("C2"));
            lvi.SubItems.Add(araba.KDVDahilFiyat.ToString("C2"));
            listView1.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Lpg");

            cmbVites.Items.Add("Manuel");
            cmbVites.Items.Add("Otomatik");

            cmbKasaTip.Items.Add("Sedan");
            cmbKasaTip.Items.Add("Hatchback");

        }
    }
}
