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

            // average from the odd numbers - METHOD approach
            var finalList = numbers.Where(n => n % 2 != 0).ToList();
            var avg = finalList.Average();
            Console.WriteLine(avg);

            // average from the odd numbers - QUERY approach
            var finalListQuery = from number in numbers
                                 where number % 2 != 0
                                 select number;

            var avg2 = finalListQuery.Average();
            Console.WriteLine(avg2);

            Console.ReadLine();
        }
    }
}
