using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int freeSpot = 0;

            Console.WriteLine("The default setup is: " + a + " and " + b);

            freeSpot = b;
            b = a;
            a = freeSpot;

            Console.WriteLine("The default setup is: " + a + " and " + b);
            Console.ReadLine();
        }
    }
}
