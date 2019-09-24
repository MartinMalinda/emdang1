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
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            Console.Write("Type your divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                int result = 10 / divisor;
                Console.WriteLine("The result is " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You CANNOT divide by zero!");
            }

            Console.ReadLine();

        }

    }
}
