using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end`

            string[] animals = new string[3] { "koal", "pand", "zebr" };

            Console.WriteLine(animals.Length);


            for (int j = 0; j < animals.Length; j++) // row loop
            {
                animals[j] = animals[j] + "a";
            }

            for (int k = 0; k < animals.Length; k++) // row loop
            {
                Console.WriteLine(animals[k]);
            }

            Console.ReadKey();
        }
    }
}

