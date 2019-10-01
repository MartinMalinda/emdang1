using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class F35 : Aircraft
    {
        public F35(int ammo) : base(ammo)
        {
            MaxAmmo = 12;
            BaseDamage = 50;

            if (ammo > 0 && ammo <= MaxAmmo)
            {
                Ammo = ammo;
            }
            else
            {
                Console.WriteLine("The F16 can hold only " + MaxAmmo + "ammo");
            }
        }

    }
}
