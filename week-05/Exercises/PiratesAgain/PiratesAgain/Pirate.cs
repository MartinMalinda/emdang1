using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesAgain
{
    class Pirate
    {

        
        public string Name { get; set; }
        public int Health { get; set; } = 10;
        public int Gold { get; set; }

        public bool HasWoodenLeg { get; set; } = false;


        public pirateType PirateType { get; set; }

        public enum pirateType
        {
            Captain,
            FellowPirate
        }

        public Pirate(string name, int gold, pirateType Type, bool hasWoodenLeg)
        {
            Name = name;
            Gold = gold;
            PirateType = Type;
        }

        public void Work()
        {
            if (this.PirateType == pirateType.Captain)
            {
                this.Gold += 10;
                this.Health -= 5;
            }
            else
            {
                this.Gold += 1;
                this.Health -= 1;
            }

        }

        public void Party()
        {
            if(this.PirateType == pirateType.Captain)
            {
                this.Health += 10;
            }
            else
            {
                this.Health += 1;
            }
        }

        public override string ToString()
        {
            if (this.HasWoodenLeg == true)
            {
                return $"Hello, I'm {this.Name}. I have a wooden leg and {this.Gold} golds.";
            }
            else
            {
                return $"Hello, I'm {this.Name}. I still have my real legs and {this.Gold} golds.";
            }
        }
    }
}
