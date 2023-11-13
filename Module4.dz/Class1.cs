using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4.dz
{
   
    public partial class Car
    {
        // Закрытые поля
        private string brand;
        private int year;
        private double engineCapacity;
        private bool isAutomatic;
        private string color;

        // Статические поля
        private static int totalCarsProduced;
        private static double totalEngineCapacity;

        // Статический конструктор
        static Car()
        {
            totalCarsProduced = 0;
            totalEngineCapacity = 0.0;
        }

        // Конструктор по умолчанию
        public Car()
        {
            brand = "Unknown";
            year = 0;
            engineCapacity = 0.0;
            isAutomatic = false;
            color = "Unknown";

            totalCarsProduced++;
        }

        // Перегруженные конструкторы
        public Car(string brand, int year, double engineCapacity, bool isAutomatic, string color)
        {
            this.brand = brand;
            this.year = year;
            this.engineCapacity = engineCapacity;
            this.isAutomatic = isAutomatic;
            this.color = color;

            totalCarsProduced++;
            totalEngineCapacity += engineCapacity;
        }

        // Метод доступа к закрытому полю brand
        public string GetBrand()
        {
            return brand;
        }

        // Метод управления классом (изменение цвета)
        public void ChangeColor(string newColor)
        {
            color = newColor;
        }

        // Метод, в который передаются аргументы по ссылке
        public void ModifyEngineCapacity(ref double newEngineCapacity)
        {
            engineCapacity = newEngineCapacity;
        }

        // Метод доступа к статическому полю totalCarsProduced
        public static int GetTotalCarsProduced()
        {
            return totalCarsProduced;
        }

        // Метод доступа к статическому полю totalEngineCapacity
        public static double GetTotalEngineCapacity()
        {
            return totalEngineCapacity;
        }
    }

}
