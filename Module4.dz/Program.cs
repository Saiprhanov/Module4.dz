using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Module4.dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", 2022, 2.5, true, "Red");
            Car car2 = new Car("Honda", 2021, 1.8, false, "Blue");

            Console.WriteLine("Total Cars Produced: " + Car.GetTotalCarsProduced());
            Console.WriteLine("Total Engine Capacity: " + Car.GetTotalEngineCapacity() + "L");

            car1.DisplayCarInfo();
            car2.DisplayCarInfo();

            Console.ReadLine();
        }
    }
}
