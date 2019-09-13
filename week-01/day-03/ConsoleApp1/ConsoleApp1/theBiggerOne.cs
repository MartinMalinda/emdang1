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
            Console.WriteLine("Type the an integer number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the an integer number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The bigger number is num1 AKA: " + num1);
            }
            else Console.WriteLine("The bigger number is num2 AKA: " + num2);
            Console.ReadLine();

            // Write a program that asks for two numbers and prints the bigger one
        }
    }
}

