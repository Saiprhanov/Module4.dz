using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4.dz
{
    
    public partial class Car
    {
        // Дополнительный метод
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Engine Capacity: {engineCapacity}L");
            Console.WriteLine($"Automatic: {(isAutomatic ? "Yes" : "No")}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine();
        }
    }

}
