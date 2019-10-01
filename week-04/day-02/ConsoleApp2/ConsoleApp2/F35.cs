using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class F35 : Aircraft
    {
        public F35()
        {
            MaxAmmo = 12;
            BaseDamage = 50;
            Type = AircraftType.F35;
            FillPriority = true;
        }

    }
}
