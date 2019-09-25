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
            Counter counter1 = new Counter(200);
            Console.WriteLine(counter1.Get()); 

            Console.WriteLine();

            counter1.Add(10);
            Console.WriteLine(counter1.Get());

            Console.WriteLine();

            counter1.Reset();
            Console.WriteLine(counter1.Get());

            Console.ReadKey();
        }
    }
}
