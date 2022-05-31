using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Builder
{
    public class BmwConcrete : CarBuilder
    {

        public BmwConcrete()
        {
            car = new Car();
        }
        public override void CreateBrandName()
        {
            car.ModelName = "BMW";
        }

        public override void CreateColor()
        {
            car.Color = "Grey";
        }

        public override void CreateModelName()
        {
            car.ModelName = "7 Series";
        }
    }
}
