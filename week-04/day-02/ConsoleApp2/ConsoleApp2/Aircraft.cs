using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Aircraft
    {
        public int MaxAmmo { get; protected set; }
        public int BaseDamage { get; protected set; }
        public int Ammo { get; protected set; } = 0;

        public Aircraft(int ammo)
        {
            Ammo = ammo;
        }

        //public Aircraft(int maxAmmo, int baseDamage)
        //{
        //    MaxAmmo = maxAmmo;
        //    BaseDamage = baseDamage;
        //}

        public void fight()
        {

        }
    }
}
