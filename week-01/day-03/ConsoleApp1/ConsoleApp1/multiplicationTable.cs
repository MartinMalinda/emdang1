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
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150

            Console.WriteLine("What this mupliplication table should be number of? : ");
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine(i + " * " + num + " = " + result);
            }

            Console.ReadLine();
        }
    }
}

