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
            Console.WriteLine("Type the number: ");
            int num1 = int.Parse(Console.ReadLine());

            if(num1 % 2 == 0)
            {
                Console.WriteLine("E V E N");
            }
            else Console.WriteLine("O D D");

            Console.ReadLine();
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
        }
    }
}

