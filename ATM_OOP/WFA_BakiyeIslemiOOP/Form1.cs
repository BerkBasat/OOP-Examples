using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //decimal bakiye = 500;
        //decimal cekilenTutar = 0;
        //decimal yatirilanTutar = 0;
        string hataMesaj = "Bakiyeniz yetersiz lütfen bakiye yükleyin...";

        Atm atm = new Atm();
        Shop shoppingList = new Shop();
        private void Form1_Load(object sender, EventArgs e)
        {
            atm.Bakiye = 500;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            lblBakiye.Text = atm.Bakiye.ToString("C2");
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            atm.Withdraw = 0;

            if (atm.Bakiye >= nudParaCek.Value)
            {
                if (nudParaCek.Value > 0)
                {
                    atm.Bakiye -= nudParaCek.Value;
                    lblBakiye.Text = atm.Bakiye.ToString("C2");
                    atm.Withdraw = nudParaCek.Value;
                    listBox1.Items.Add("Para Çekme: " + atm.Withdraw.ToString("C2"));
                }
                

            }
            else
            {
                MessageBox.Show(hataMesaj);
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            atm.Deposit = 0;
            if (nudParaYatir.Value > 0)
            {
                atm.Bakiye += nudParaYatir.Value;
                lblBakiye.Text = atm.Bakiye.ToString("C2");
                atm.Deposit = nudParaYatir.Value;
                listBox1.Items.Add("Para Yatırma :" + atm.Deposit.ToString("C2"));
            }
            else
            {
                MessageBox.Show("en az 1 TL yükleyin...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shoppingList.TotalAmount = 0;
            shoppingList.Order = "";
            //decimal toplamTutar = 0;
            //string siparis = "";

            if (atm.Bakiye > 0)
            {
                if (chkEkmek.Checked)
                {
                    shoppingList.TotalAmount += 4;
                    shoppingList.Order += " Ekmek ";

                }
                if (chkYumurta.Checked)
                {
                    shoppingList.TotalAmount += 20;
                    shoppingList.Order += " Yumurta ";
                }
                if (chkCay.Checked)
                {
                    shoppingList.TotalAmount += 35;
                    shoppingList.Order += " Çay ";
                }
                if (chkCikoloata.Checked)
                {
                    shoppingList.TotalAmount += 30;
                    shoppingList.Order += " Cikolata ";
                }
                if (chkPeynir.Checked)
                {
                    shoppingList.TotalAmount += 45;
                    shoppingList.Order += " Peynir ";
                }

                

                if (shoppingList.TotalAmount <= atm.Bakiye)
                {
                    lblToplam.Text = shoppingList.TotalAmount.ToString("C2");
                    listBox2.Items.Add(shoppingList.Order + " Toplam :" + shoppingList.TotalAmount.ToString("C2"));
                    atm.Bakiye -= shoppingList.TotalAmount;
                    lblBakiye.Text = atm.Bakiye.ToString("C2");
                    lblToplam.ForeColor = Color.Green;
                }
                else
                {
                    lblToplam.ForeColor = Color.Red;
                    MessageBox.Show(hataMesaj);
                }
            }
            else
            {
                MessageBox.Show(hataMesaj);
            }
        }
    }
}
