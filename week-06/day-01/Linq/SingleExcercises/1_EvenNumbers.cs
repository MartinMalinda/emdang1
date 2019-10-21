using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // even numbers from the array
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var finalList = numbers.Where(n => n % 2 == 0).ToList();
            finalList.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
