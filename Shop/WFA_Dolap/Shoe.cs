using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Shoe:Product
    {
        public override string ToString()
        {
            return $"{ProductName} {CategoryName} {OrderDate} {Price}";
        }
    }
}
