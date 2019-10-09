using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plant
    {
        
        public string Color { get; protected set; }
        public int WaterAmount { get; protected set; }
        public int WaterAbsorbtion { get; protected set; }
        public int CurrentWaterLevel { get; set; } = 0;

        public bool NeedsWater { get; set; } = true;


        
    }
}
