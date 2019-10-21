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
            string text = "lalalaa";

            //Write a LINQ Expression to find the frequency of characters in a given string.

            var finalList = text.GroupBy(n => n).ToList();
            finalList.ForEach(n => Console.WriteLine(n.Key + " : " + n.Count()));

            Console.WriteLine();

            //Write a LINQ Expression to find the frequency of characters in a given string.
            // doesnt need "select" because group itself 
            var finalListQuery = from character in text
                                 group character by character;
                                 
            finalListQuery.ToList().ForEach(n => Console.WriteLine(n.Key + " : " + n.Count()));

            Console.ReadLine();
        }
    }
}
