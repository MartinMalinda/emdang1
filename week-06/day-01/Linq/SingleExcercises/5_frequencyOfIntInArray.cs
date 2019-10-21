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
            int[] numbers  = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            // Write a LINQ Expression to find the frequency of numbers in the following array: METHOD approach
            var finalList = numbers.GroupBy(n => n).ToList();
            finalList.ForEach(n => Console.WriteLine(n.Key + " : " + n.Count()));

            Console.WriteLine();

            // Write a LINQ Expression to find the frequency of numbers in the following array:QUERY approach
            // doesnt need "select" because group itself 
            var finalListQuery = from number in numbers
                                 group number by number;
                                 
            finalListQuery.ToList().ForEach(n => Console.WriteLine(n.Key + " : " + n.Count()));

            Console.ReadLine();
        }
    }
}
