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
            int a = 13;
            int b = 22;

            Console.WriteLine("The addition of " + a + " and " + b + " is " + (a+b));
            Console.WriteLine("The substraction of " + a + " and " + b + "is " + (a-b));
            Console.WriteLine("The multiplication of " + b + " and " + a + " is " + (a*b));
            Console.WriteLine("The division of " + b + " and " + a + " is " + ((double)b/a));
            Console.WriteLine("The integer part of division of " + b + " and " + a + " is " + (b / a));
            Console.WriteLine("The remainder of division of " + b + " and " + a + " is " + (b%a));

            Console.ReadLine();
        }
    }
}
