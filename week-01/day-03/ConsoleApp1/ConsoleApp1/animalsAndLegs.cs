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

            Console.WriteLine("Type how many chicken the farmer has: ");
            int chickens = int.Parse(Console.ReadLine());

            Console.WriteLine("Type how many chicken the farmer has: ");
            int cows = int.Parse(Console.ReadLine());

            int legs = chickens * 2 + cows * 4;

            Console.WriteLine("Together, there are " + legs + " legs on the farm");
            Console.ReadLine();

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
        }
    }
}

