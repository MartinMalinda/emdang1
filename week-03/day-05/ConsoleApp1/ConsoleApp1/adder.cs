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
            Console.WriteLine("Hello user, please type your limit number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("The sum of all number from the limit you typed is: ");
            Console.Write(Adder(input));
            Console.ReadKey();
        }

        public static int Adder(int n)
        {
            if (n == 1)         // base case or "bottom" which we then come to top from 
            {
                return 1;
            }
            else
            {
                return n + Adder(n - 1);
            }

        }
    }

}
