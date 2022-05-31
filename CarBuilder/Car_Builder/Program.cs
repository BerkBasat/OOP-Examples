using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder car = new AudiConcrete();

            CreateCar newCar = new CreateCar();

            newCar.CreateNewCar(car);
            Console.WriteLine(car.Car.ToString());
            Console.ReadLine();
        }
    }
}
