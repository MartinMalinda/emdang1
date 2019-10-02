using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Instrument
    {
        //protected string name;
        protected string Name { get; set; }
        public abstract void Play();
    }
}
