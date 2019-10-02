using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Violin:StringedInstrument
    {
        public Violin()
        {
            Name = "Violin";
            NumberOfStrings = 4;
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
