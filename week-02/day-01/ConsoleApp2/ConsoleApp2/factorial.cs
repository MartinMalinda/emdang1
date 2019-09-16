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
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

            Console.Write("Please write the end-number: ");
            int endNumber = int.Parse(Console.ReadLine());
            Console.Write("The sum of the number from 0 to your end number is: ");
            Console.Write(factorial(endNumber));

            Console.ReadKey();
        }

        public static int factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <=x; i++)
            {
                result = result * i;
            }
            return result;
        }

    }
}

