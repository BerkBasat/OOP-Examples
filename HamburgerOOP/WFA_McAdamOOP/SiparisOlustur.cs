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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        public static List<Order>orderList = new List<Order>();

        private void SiparisOlustur_Activated(object sender, EventArgs e)
        {
            rbKucuk.Checked = true;
            foreach (Hamburger hamburger in MenuOlustur.hamburgerList)
            {
                cmbMenu.Items.Add(hamburger);
            }

            foreach (Extra extra in EkstraOlustur.extraList)
            {
                CheckBox chk = new CheckBox();
                chk.Text = extra.Name;
                chk.Tag = extra;
                flowLayoutPanel1.Controls.Add(chk);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.SelectedMenu = (Hamburger)cmbMenu.SelectedItem;

            if (rbKucuk.Checked)
            {
                order.Size = WFA_McAdam.Size.Small;
            }
            else if (rbOrta.Checked)
            {
                order.Size = WFA_McAdam.Size.Medium;
            }
            else if (rbBuyuk.Checked)
            {
                order.Size = WFA_McAdam.Size.Large;
            }

            order.Extra = new List<Extra>();

            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    Extra extra = (Extra)chk.Tag;
                    order.Extra.Add(extra);
                }
            }
            order.Amount = Convert.ToInt32(nudAdet.Value);
            order.Hesapla();
            listBox1.Items.Add(order);
            OrderTotal();
        }

        public decimal OrderTotal()
        {
            decimal total = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Order order = (Order)listBox1.Items[i];
                total += order.Total;
            }
            lblToplamTutar.Text = total.ToString("C2");
            return total;
        }

        private void btnSiparisiTamamla_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam: " + OrderTotal().ToString("C2") + " Siparişinizi Tamamlamak İstiyormusunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Order order = (Order)listBox1.Items[i];
                    orderList.Add(order);
                }

                listBox1.Items.Clear();
                lblToplamTutar.Text = "0 TL";
                MessageBox.Show("Sipariş tamamlandı");
            }
        }
    }
}

