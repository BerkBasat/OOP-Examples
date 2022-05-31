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
    public partial class EkstraOlustur : Form
    {
        public EkstraOlustur()
        {
            InitializeComponent();
        }
        public static List<Extra> extraList = new List<Extra>();
        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra();
            extra.Name = txtEkstra.Text;
            extra.Price = nudEkstraFiyat.Value;
            extraList.Add(extra);

            txtEkstra.Text = "";
            nudEkstraFiyat.Value = 0;

            MessageBox.Show("Ekstra Eklendi!");
        }
    }
}
