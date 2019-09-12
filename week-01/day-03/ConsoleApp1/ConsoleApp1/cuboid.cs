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


            Console.WriteLine("CUBOID - Surface and volume calculator");
            Console.WriteLine();

            Console.WriteLine("Type the lenght of side A (decimals supported): ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the lenght of side B (decimals supported): ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the lenght of side C (decimals supported): ");
            double c = double.Parse(Console.ReadLine());

            double Surface = 2 * (a * b + b * c + a * c);
            double Volume = a * b * c;

            Console.WriteLine("Surface of the given cuboid is: " + Surface);
            Console.WriteLine("Volume of the given cuboid is:" + Volume);

            Console.ReadLine();


        }
    }
}

