using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_InsanKaynaklari
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public DateTime IseGiris { get; set; }
        public Departman Departman { get; set; }
    }
}
