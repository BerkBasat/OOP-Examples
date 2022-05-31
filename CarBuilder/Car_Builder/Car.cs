using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Builder
{
    public class Car
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Brand: {BrandName}, Model {ModelName}, Color: {Color}";
        }
    }
}
