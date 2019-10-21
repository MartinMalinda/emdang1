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
            string text = "ChAnGiNgSiZe";

            //Write a LINQ Expression to find the uppercase characters in a string.

            var finalList = text.Where(c => char.IsUpper(c)).ToList();      // IsLower() as opposite
            finalList.ForEach(c => Console.WriteLine(c));

            Console.WriteLine();

            //Write a LINQ Expression to find the uppercase characters in a string.
            var finalListQuery = from character in text
                                 where char.IsUpper(character)
                                 select character;

            finalListQuery.ToList().ForEach(c => Console.WriteLine(c));

            Console.ReadLine();
        }
    }
}
