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
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine("I won't cheat on the exam!");
            }

            Console.ReadLine();
        }
    }
}

