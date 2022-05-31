using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Builder
{
    public class CreateCar
    {
        public void CreateNewCar(CarBuilder Car)
        {
            Car.CreateBrandName();
            Car.CreateModelName();
            Car.CreateColor();
        }
    }
}
