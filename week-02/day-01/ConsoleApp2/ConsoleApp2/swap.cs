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
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = new string[3] { "first", "second", "third" };

            Console.WriteLine(abc.Length);

            string temp;
            temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            Console.WriteLine(abc[0] +" " + abc[1] + " " + abc[2]);
           

            Console.ReadKey();
        }
    }
}

