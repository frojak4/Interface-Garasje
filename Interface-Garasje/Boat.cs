using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Garasje
{
    internal class Boat : IVehicles
    {
        public string brand { get; set; }
        public string name { get; set; }
        public int year { get; set; }

        public void drive()
        {
            Console.WriteLine("Brrr brrr");
        }

        public Boat(string Brand, string Name, int Year)
        {
            Brand = brand;
            Name = name;
            Year = year;
        }
    }
}
