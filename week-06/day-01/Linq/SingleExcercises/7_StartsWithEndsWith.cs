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
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "AI", "A Slovo I" };

            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:


            var finalList = cities.Where(n=> n.StartsWith("A") && n.EndsWith("I")).ToList();
            finalList.ForEach(n => Console.WriteLine(n));

            Console.WriteLine();

            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            var finalListQuery = from word in cities
                                 where word.StartsWith("A") && word.EndsWith("I")
                                 select word;
                                 
            finalListQuery.ToList().ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
