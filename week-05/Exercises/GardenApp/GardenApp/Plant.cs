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
        public double WaterAbsorbtion { get; protected set; }
        public double CurrentWaterLevel { get;  protected set; } = 0;

        public bool NeedsWater { get;  protected set; } = false;

        

        public void SetNeedsWater(bool status)
        {
            NeedsWater = status;
        }

        public virtual void SetCurrentWaterLevel(int water)
        {
        }

        public string NeedsWaterStringStatus()
        {
            if(this is Flower && this.CurrentWaterLevel < 5)
            {
                return "needs water";
            }
            if(this is Tree && this.CurrentWaterLevel < 10)
            {
                return "needs water";
            }
            return "doesnt need water";
        }
    }
}
