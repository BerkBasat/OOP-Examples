using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_InsanKaynaklari
{
    public class Departman
    {
        public string Ad { get; set; }
        public int KişiSayisi { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
