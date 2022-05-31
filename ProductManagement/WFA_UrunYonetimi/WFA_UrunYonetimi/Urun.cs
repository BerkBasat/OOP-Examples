using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_UrunYonetimi.Database;

namespace WFA_UrunYonetimi
{
    public abstract class Urun:IRepository
    {
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }

        

        public string Add()
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public List<Urun> List()
        {
            return FakeData.urunListesi;
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
