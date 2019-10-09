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
            WaterAbsorbtion = 0.75;
        }


        public override string ToString()
        {
            return "Flower";
        }

        public override void SetCurrentWaterLevel(int water)
        {
            CurrentWaterLevel += (water * WaterAbsorbtion);
        }
    }
}
