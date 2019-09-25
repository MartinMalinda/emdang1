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
            Sharpie sharpie1 = new Sharpie("Black", 5);
            Sharpie sharpie2 = new Sharpie("Red", 3);

            Console.WriteLine($"Sharpie1 Ink amount: {sharpie1.InkAmount}");
            Console.WriteLine($"Sharpie2 Ink amount: {sharpie2.InkAmount}");

            sharpie1.Use(10.5);
            sharpie2.Use(50.5);

            Console.WriteLine();

            Console.WriteLine($"Sharpie1 Ink amount: {sharpie1.InkAmount}");
            Console.WriteLine($"Sharpie2 Ink amount: {sharpie2.InkAmount}");

            Console.Read();

        }
    }
}
