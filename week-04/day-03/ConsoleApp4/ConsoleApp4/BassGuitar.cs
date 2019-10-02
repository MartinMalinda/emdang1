using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class BassGuitar:StringedInstrument
    {
        public BassGuitar()
        {
            Name = "Bass Guitar";
            NumberOfStrings = 4;
        }

        public BassGuitar(int numOfStrings)
        {
            Name = "Bass Guitar";
            NumberOfStrings = numOfStrings;
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
