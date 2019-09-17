using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            string example = "In a dishwasher far far away";

            //example.Replace("dishwasher", "galaxy");  === úprava se normalně do toho neukládá 
            Console.WriteLine(example);

            Console.WriteLine(example.Replace("dishwasher", "galaxy"));  // hned vypsat output

            string newExample = example.Replace("dishwasher", "galaxy");    // output uložit do nové proměnné a pak vypsat
            Console.WriteLine(newExample);

            Console.ReadLine();
        }
    }
}
