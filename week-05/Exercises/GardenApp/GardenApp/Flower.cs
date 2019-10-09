using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(string color)
        {
            Color = color;
        }


        public override string ToString()
        {
            return "Flower";
        }
    }
}
