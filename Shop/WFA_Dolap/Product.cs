using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Product
    {
        public Product()
        {
            OrderDate = DateTime.Now;
        }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
    }
}
