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
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Type your number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();        //separator

            for (int i = 0; i < num; i++)           // for loop for rows
            {
                for (int a = 0; a <= i; a++)        // for loop for typing stars
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}