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
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i%3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }else
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}