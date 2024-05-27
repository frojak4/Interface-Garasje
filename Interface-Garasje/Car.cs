using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Garasje
{
    internal class Car : IVehicles
    {
        public string brand { get; set; }
        public string name { get; set; }
        public int year { get; set; }

        public void drive()
        {
            Console.WriteLine("Vroom Vroom");
        }


        public Car(string Brand, string Name, int Year)
        {
            Brand = brand;
            Name = name;
            Year = year;
        }
    }
}
