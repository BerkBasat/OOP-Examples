using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam
{
    public class Order
    {
        public Hamburger SelectedMenu { get; set; }
        public Size Size { get; set; }

        public List<Extra> Extra { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }

        public void Hesapla()
        {
            Total = 0;
            Total = SelectedMenu.Price;

            switch (Size)
            {
                case Size.Small:
                    Total += 0;
                    break;
                case Size.Medium:
                    Total += 3;
                    break;
                case Size.Large:
                    Total += 5;
                    break;
            }

            foreach (Extra extra in Extra)
            {
                Total += extra.Price;
            }

            Total *= Amount;
            
        }

        public override string ToString()
        {
            if (Extra.Count < 1)
            {
                return $"{SelectedMenu} Menu, {Size}, {Amount} Adet, Toplam: {Total.ToString("C2")}";
            }
            else
            {
                string extras = "";
                foreach (Extra extra in Extra)
                {
                    extras += extra.Name + " ";
                }

                extras = extras.Trim();
                return $"{SelectedMenu} Menu, {Size}, Ekstra: ({extras}), {Amount} Adet, Toplam: {Total.ToString("C2")}";
            }
        }
    }
}
