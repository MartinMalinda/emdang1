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
            Console.WriteLine("Type the an integer number: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Not enough");
            } else if (num == 1){
                Console.WriteLine("ONE");
            } else if (num == 2){
              Console.WriteLine("TWO");
            }
            else Console.WriteLine("A lot");
            Console.ReadLine();

            // Write a program that reads a number from the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
        }
    }
}

