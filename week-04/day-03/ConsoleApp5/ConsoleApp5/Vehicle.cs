using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Vehicle
    {
        private string name;
        private int fuel;
        private int mileage;

        public string Name { get; set; }
        public string Fuel { get; set; }
        public string Mileage { get; set; }

    }
}
