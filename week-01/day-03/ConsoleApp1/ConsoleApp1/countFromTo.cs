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
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Type the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            while (num2 <= num1)
            {
                Console.WriteLine("The second number should be bigger");
                Console.WriteLine("Type the second integer AGAIN: ");
                num2 = int.Parse(Console.ReadLine());

            }

            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(num1++);
            }

            Console.ReadLine();
        }
    }
}