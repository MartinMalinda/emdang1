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
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`

            int baseNum = 123; //123

            Console.WriteLine(Doubling(baseNum));

            Console.ReadKey();
        }

        public static int Doubling(int x)
        {
            int doubledNumber = x*2;
            //Console.WriteLine(doubledNumber);
            return doubledNumber;
        }

    }
}

