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
            Console.WriteLine("Please type a distance in miles (decimal supported): ");
            double miles = double.Parse(Console.ReadLine());

            double milesToKilometers = miles / 5 * 8;
            Console.WriteLine("The given distance in kilometers is: " + milesToKilometers );
            Console.ReadLine();
        }
    }
}

