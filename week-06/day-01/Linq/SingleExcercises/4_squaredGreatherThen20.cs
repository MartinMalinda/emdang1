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
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            // average from the odd numbers - METHOD approach
            var finalList = numbers.Where(n => n * n > 20).ToList();    // doesnt need select
            finalList.ForEach(n => Console.WriteLine(n));

            Console.WriteLine();

            // average from the odd numbers - QUERY approach
            var finalListQuery = from number in numbers
                                 where number * number > 20
                                 select number;
            finalListQuery.ToList().ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
