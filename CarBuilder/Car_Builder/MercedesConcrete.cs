using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Builder
{
    public class MercedesConcrete : CarBuilder
    {

        public MercedesConcrete()
        {
            car = new Car();
        }
        public override void CreateBrandName()
        {
            car.BrandName = "Mercedes";
        }

        public override void CreateColor()
        {
            car.Color = "White";
        }

        public override void CreateModelName()
        {
            car.ModelName = "C Class";
        }
    }
}
