using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarsystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // If someone has no pair, he/she should be the element of the list too
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }

        public static string MakingMatches(List<string> girlList, List<string> boyList)
        {
            List<string> pairs = new List<string>();

            for (int i = 0; i < girlList.Count; i++)
            {
                pairs.Add(girlList[i]);
                pairs.Add(boyList[i]);
            }

            string[] pairsArray = pairs.ToArray();
            string finalPairs = String.Join(", ", pairsArray);
            return finalPairs;
        }
    }
}
