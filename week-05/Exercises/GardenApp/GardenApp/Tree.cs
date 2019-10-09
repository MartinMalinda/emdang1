using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            Color = color;
            WaterAbsorbtion = 0.40;

        }

        public override string ToString()
        {
            return "Tree";
        }

        public override void SetCurrentWaterLevel(int water)
        {
            CurrentWaterLevel += (water * WaterAbsorbtion);
        }
    }
}
