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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdet = 0;

            if (SiparisOlustur.orderList.Count > 0)
            {
                foreach (Order order in SiparisOlustur.orderList)
                {
                    ciro += order.Total;
                    foreach (Extra extra in order.Extra)
                    {
                        ekstraMalzemeGeliri += extra.Price;
                    }
                    ekstraMalzemeGeliri *= order.Amount;
                    satisAdet += order.Amount;
                    listBox1.Items.Add(order);
                }

                lblCiro.Text = ciro.ToString("C2");
                lblToplamSiparis.Text = ekstraMalzemeGeliri.ToString("C2");
                lblSatilanUrunAdet.Text = satisAdet.ToString();
                lblToplamSiparis.Text = listBox1.Items.Count.ToString();
            }
        }
    }
}
