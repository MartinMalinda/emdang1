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
            Console.WriteLine("Hello user, please type your BASE number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello user, please type the POWER number: ");
            int power = int.Parse(Console.ReadLine());
            Console.Write("The result is: ");
            Console.Write(powerN(input, power));
            Console.ReadKey();
        }


        public static int powerN(int number, int n)
        {
            if (n == 1)
            {
                return number;
            }
            else
            {
                return number * powerN(number, n - 1);
            }
        }
    }

}
