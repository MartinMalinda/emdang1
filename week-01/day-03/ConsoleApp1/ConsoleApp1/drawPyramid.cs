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
           
            Console.Write("Type the level number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)      // row loop
            {
                for (int a = num; a>i; a--) // space loop
                {
                    Console.Write(" ");
                }

                for (int b = 1; b <= ((i*2)-1); b++)    //star loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            /*
            for (j = 1; j < num - i + 1; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write(i);
                //Console.Write(" ");
            }
            Console.WriteLine();

            */



            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //                          spaces          stars celkem >>> num + 2
            //    *                     num-1
            //   ***                    num-2
            //  *****                   num-3
            // *******                  num-num
            //
            // The pyramid should have as many lines as the number was

            /*
            Console.WriteLine("Type your number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine();        //separator

        for (int i = 0; i < num; i++)           // for loop for rows | 0<4 yes |
        {
            for (int iSpace = 0; iSpace < (num-1); iSpace++)    // loop for spaces  | 0<3 yes | 1<3 yes | 2<3 yes | 3<3 no | 
            {
                Console.Write(" ");
            }

            for (int a = 0; a <= i; a++)        // for loop for typing stars
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }*/
        }
    }
}