using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ElectricGuitar : StringedInstrument
    {
        
        public ElectricGuitar()
        {
            Name = "Electric Guitar";
            NumberOfStrings = 6;
        }

        public ElectricGuitar(int numOfStrings)
        {
            Name = "Electric Guitar";
            NumberOfStrings = numOfStrings;
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}
