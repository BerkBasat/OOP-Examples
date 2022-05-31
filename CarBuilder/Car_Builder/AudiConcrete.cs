using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Builder
{
    public class AudiConcrete : CarBuilder
    {

        public AudiConcrete()
        {
            car = new Car();
        }

        public override void CreateBrandName()
        {
            car.BrandName = "Audi";
        }

        public override void CreateColor()
        {
            car.Color = "Black";
        }

        public override void CreateModelName()
        {
            car.ModelName = "A5";
        }
    }
}
