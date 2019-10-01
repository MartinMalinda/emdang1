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

        public bool FillPriority { get; protected set; } 

        public AircraftType Type { get; protected set; }

        public enum AircraftType
        {
            F16, 
            F35
        }

        public Aircraft()
        {
            
        }

        public void Fight()
        {
            int finalDamage = Ammo * BaseDamage;
            Console.WriteLine("The Final damage was: " + finalDamage);
            Ammo = 0;
        }

        public int Refill(int refillAmmo)
        {
            Ammo = Ammo + (MaxAmmo - Ammo);
            refillAmmo = refillAmmo - (MaxAmmo - Ammo);
            return refillAmmo;
        }

        
        public string GiveType()
        {
            string result = Type.ToString();
            return result;
        }

        public void GetStatus()
        {
            Console.WriteLine("Type: " + Type + ", Ammo: " + Ammo + ", Base Damage: " + BaseDamage + ", All Damage: " + (Ammo * BaseDamage));
        }

        public bool IsPriority()
        {
            return FillPriority;
        }
    }
}
