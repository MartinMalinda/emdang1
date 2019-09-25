using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sharpie
    {
        public string Color { get; set; }
        public double Width { get; set; }
        public double InkAmount { get; set; } = 100;

        public Sharpie(string Color, double Width)
        {

        }

        public void Use(double usedInk)
        {
            InkAmount = InkAmount - usedInk;
        }
    }
}
