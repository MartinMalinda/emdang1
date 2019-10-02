using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class StringedInstrument : Instrument
    {
        private int numberOfStrings;

        public int NumberOfStrings { get; set; }

        public override void Play()
        {
            Console.WriteLine(Name + ", a " + NumberOfStrings + "-stringed instrument that " + Sound() +"s");
        }

        public abstract string Sound();
    }
}
