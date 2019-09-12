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

            Console.WriteLine("Type the number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the number 4: ");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the number 5: ");
            int num5 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;
            int avg = sum / 5;

            Console.WriteLine("The sum of the given numbers is: " + sum + " and the average is: " + avg);
            Console.ReadLine();


        }
    }
}

