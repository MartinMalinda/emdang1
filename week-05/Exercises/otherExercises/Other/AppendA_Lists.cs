using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarsystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "bo", "anacond", "koal", "pand", "zebr" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            far = AppendA(far);

            foreach (var item in far)
            {
                Console.WriteLine(item);
            }
            // Expected output: "boa", "anaconda", "koala", "panda", "zebra"
            Console.ReadLine();
        }

        public static List<string> AppendA(List<string> list)
        {
            list = list.Select(x => x + "a").ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            return list;
        }
    }
}
