using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Product> products = new List<Product>();
        List<Product> selectedProduct = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {


            Shoe shoe1 = new Shoe();
            shoe1.ProductName = "Nike";
            shoe1.CategoryName = "Outdoor";
            shoe1.OrderDate.ToShortTimeString();
            shoe1.Price = 300;

            Shoe shoe2 = new Shoe();
            shoe2.ProductName = "Adidas";
            shoe2.CategoryName = "Jogging";
            shoe2.OrderDate.ToShortTimeString();
            shoe2.Price = 400;

            Shoe shoe3 = new Shoe();
            shoe3.ProductName = "Converse";
            shoe3.CategoryName = "Daily";
            shoe3.OrderDate.ToShortTimeString();
            shoe3.Price = 500;

            Tshirt tshirt1 = new Tshirt();
            tshirt1.ProductName = "Everlane";
            tshirt1.CategoryName = "James Perse";
            tshirt1.OrderDate.ToShortTimeString();
            tshirt1.Price = 500;

            Tshirt tshirt2 = new Tshirt();
            tshirt2.ProductName = "Uniqlo";
            tshirt2.CategoryName = "T-Shirtable";
            tshirt2.OrderDate.ToShortTimeString();
            tshirt2.Price = 450;

            Tshirt tshirt3 = new Tshirt();
            tshirt3.ProductName = "James Perse";
            tshirt3.CategoryName = "Eventual Apparel";
            tshirt3.OrderDate.ToShortTimeString();
            tshirt3.Price = 600;

            Jeans jeans1 = new Jeans();
            jeans1.ProductName = "Brand 1";
            jeans1.CategoryName = "Category 1";
            jeans1.OrderDate.ToShortTimeString();
            jeans1.Price = 300;

            Jeans jeans2 = new Jeans();
            jeans2.ProductName = "Brand 2";
            jeans2.CategoryName = "Category 2";
            jeans2.OrderDate.ToShortTimeString();
            jeans2.Price = 350;

            Jeans jeans3 = new Jeans();
            jeans3.ProductName = "Brand 3";
            jeans3.CategoryName = "Category 3";
            jeans3.OrderDate.ToShortTimeString();
            jeans3.Price = 250;

            Coat coat1 = new Coat();
            coat1.ProductName = "Coat 1";
            coat1.CategoryName = "Category 1";
            coat1.OrderDate.ToShortTimeString();
            coat1.Price = 600;

            Coat coat2 = new Coat();
            coat2.ProductName = "Coat 2";
            coat2.CategoryName = "Category 2";
            coat2.OrderDate.ToShortTimeString();
            coat2.Price = 600;

            Coat coat3 = new Coat();
            coat3.ProductName = "Coat 3";
            coat3.CategoryName = "Category 3";
            coat3.OrderDate.ToShortTimeString();
            coat3.Price = 600;

            products.Add(shoe1);
            products.Add(shoe2);
            products.Add(shoe3);
            products.Add(tshirt1);
            products.Add(tshirt2);
            products.Add(tshirt3);
            products.Add(jeans1);
            products.Add(jeans2);
            products.Add(jeans3);
            products.Add(coat1);
            products.Add(coat2);
            products.Add(coat3);

            foreach (Product product in products)
            {
                if (product is Shoe)
                {
                    Shoe shoe = (Shoe)product;
                    lstAyakkabi.Items.Add(shoe);
                }
                else if (product is Tshirt)
                {
                    Tshirt tshirt = (Tshirt)product;
                    lstTshirt.Items.Add(tshirt);
                }
                else if (product is Jeans)
                {
                    Jeans jeans = (Jeans)product;
                    lstPantolon.Items.Add(jeans);
                }
                else if (product is Coat)
                {
                    Coat coat = (Coat)product;
                    lstMont.Items.Add(coat);
                }
            }
        }

        decimal total = 0;
        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {
            Shoe selectedShoe = (Shoe)lstAyakkabi.SelectedItem;
            lstSepet.Items.Add(selectedShoe);
            total += selectedShoe.Price;
            lblToplamTutar.Text = total.ToString("C2");

            Product listedShoe = new Product();
            listedShoe.ProductName = selectedShoe.ProductName;
            listedShoe.CategoryName = selectedShoe.CategoryName;
            listedShoe.Price = selectedShoe.Price;

            selectedProduct.Add(listedShoe);
        }

        private void lstTshirt_DoubleClick(object sender, EventArgs e)
        {
            Tshirt selectedTshirt = (Tshirt)lstTshirt.SelectedItem;
            lstSepet.Items.Add(selectedTshirt);
            total += selectedTshirt.Price;
            lblToplamTutar.Text = total.ToString("C2");

            Product listedTshirt = new Product();
            listedTshirt.ProductName = selectedTshirt.ProductName;
            listedTshirt.CategoryName = selectedTshirt.CategoryName;
            listedTshirt.Price = selectedTshirt.Price;

            selectedProduct.Add(listedTshirt);
        }

        private void lstMont_DoubleClick(object sender, EventArgs e)
        {
            Coat selectedCoat = (Coat)lstMont.SelectedItem;
            lstSepet.Items.Add(selectedCoat);
            total += selectedCoat.Price;
            lblToplamTutar.Text = total.ToString("C2");

            Product listedCoat = new Product();
            listedCoat.ProductName = selectedCoat.ProductName;
            listedCoat.CategoryName = selectedCoat.CategoryName;
            listedCoat.Price = selectedCoat.Price;

            selectedProduct.Add(selectedCoat);
        }

        private void lstPantolon_DoubleClick(object sender, EventArgs e)
        {
            Jeans selectedJeans = (Jeans)lstPantolon.SelectedItem;
            lstSepet.Items.Add(selectedJeans);
            total += selectedJeans.Price;
            lblToplamTutar.Text = total.ToString("C2");

            Product listedJeans = new Product();
            listedJeans.ProductName = selectedJeans.ProductName;
            listedJeans.CategoryName = selectedJeans.CategoryName;
            listedJeans.Price = selectedJeans.Price;

            selectedProduct.Add(selectedJeans);
        }

        private void btnAlisverisiTamamla_Click(object sender, EventArgs e)
        {
            foreach (Product selected in selectedProduct)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = selected.ProductName;
                lvi.SubItems.Add(selected.CategoryName);
                lvi.SubItems.Add(DateTime.Now.ToString());
                lvi.SubItems.Add(selected.Price.ToString());
                listView1.Items.Add(lvi);

                lblGenelToplam.Text = total.ToString("C2");
            }

            selectedProduct.Clear();
            lstSepet.Items.Clear();
            lstPantolon.SelectedIndex = -1;
            lstMont.SelectedIndex = -1;
            lstAyakkabi.SelectedIndex = -1;
            lstTshirt.SelectedIndex = -1;
            lblToplamTutar.Text = 0.ToString();
        }
    }
}
