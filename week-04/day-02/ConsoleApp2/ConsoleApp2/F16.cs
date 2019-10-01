using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class F16 : Aircraft
    {

        public F16() 
        {
            MaxAmmo = 8;
            BaseDamage = 30;
            Type = AircraftType.F16;
            FillPriority = false;

            //if(ammo > 0 && ammo <= MaxAmmo)
            //{
            //    Ammo = ammo;
            //}
            //else
            //{
            //    Console.WriteLine("The F16 can hold only " + MaxAmmo + " ammo");
            //}
        }
    }
}
