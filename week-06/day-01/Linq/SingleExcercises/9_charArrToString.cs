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
            char[] charArr = { 'A', 'H', 'O', 'J' };

            //Write a LINQ Expression to convert a char array to a string.
            var finalList = String.Join("", charArr.Select(c => c.ToString()));
            Console.WriteLine(finalList);

            Console.WriteLine();

            // ??????????? 
            ////Write a LINQ Expression to find the uppercase characters in a string.
            //var finalListQuery = from character in charArr
            //                     select String.Join("", charArr.Select(c => c.ToString()));

            ////String.Join("", charArr);

            //Console.WriteLine(finalListQuery);
            Console.ReadLine();
        }
    }
}
