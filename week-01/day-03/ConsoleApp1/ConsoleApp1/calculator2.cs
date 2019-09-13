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
            double result = 0.0;
            Console.WriteLine("Hello user, this is calculator");
            Console.WriteLine("Please type the first integer number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please type the second integer number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "subtract":
                    result = num1 - num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "multiply":
                    result = num1 * num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "divide":
                    result = num1 / num2;
                    Console.WriteLine("The result is: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
            Console.ReadLine();

        }
    }
}

