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
            Console.WriteLine("Hello user, please type your number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("The sum of every signle digit from the number you typed is: ");
            Console.Write(SumDigit(input));
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

        public static int SumDigit(int n)
        {
            if (n/10 == 0)
            {
                return n;
            }
            else
            {
                return (n % 10) + SumDigit(n / 10);
                 
            }
        }
    }

}
