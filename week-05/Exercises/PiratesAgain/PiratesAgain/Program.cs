using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ship.AddPirate(new Pirate("Milos", 100, Pirate.pirateType.Captain, true));
            //ship.AddPirate(new Pirate("Milan", 10, Pirate.pirateType.FellowPirate, false));
            ship.AddPirate(new Pirate("Mirek", 100, Pirate.pirateType.Captain, true));
            ship.AddPirate(new Pirate("Milan", 10, Pirate.pirateType.FellowPirate, false));


            Console.WriteLine(ship.crew.Count);
            Console.ReadLine();
        }
    }
}
