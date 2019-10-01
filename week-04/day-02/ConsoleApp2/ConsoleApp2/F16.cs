using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class F16 : Aircraft
    {

        public F16(int ammo) : base(ammo)
        {
            MaxAmmo = 8;
            BaseDamage = 30;

            if(ammo > 0 && ammo <= MaxAmmo)
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
