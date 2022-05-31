using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AracListesi
{
    public class Araba
    {
        // public string marka; //field
        public string Marka { get; set; }
   
        public string Model { get; set; }
        public int Yıl { get; set; }
        public string SaseNo { get; set; }
        public int MotorGuc { get; set; }
        public string YakitTip { get; set; }
        public string VitesTip { get; set; }
        public int JantBoyut { get; set; }
        public string Renk { get; set; }
        public string Kasatip { get; set; }
        public decimal Fiyat { get; set; }

        public decimal KDVDahilFiyat
        {

            //read only
            get
            {
                return Fiyat * 1.18m;
            }

        }

    }
}
