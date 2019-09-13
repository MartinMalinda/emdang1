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
            //int numRow = numHeight;

            Console.WriteLine();        //separator
            //int a = 1;
            
            for (int i = 1; i <= num; i++)
            {
                while (i<=num)
                {
                    Console.WriteLine("*");
                }
                ++i;
              
            }
            

            /*
            while (a <= num)
            {
                Console.Write("*");
                ++a;
            }
            */

            Console.ReadLine();
        }
    }
}