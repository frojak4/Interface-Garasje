using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Garasje
{
    internal interface IVehicles
    {
        public string brand { get; set; }
        public string name { get; set; }
        public int year { get; set; }

        public void drive();

    }
}
