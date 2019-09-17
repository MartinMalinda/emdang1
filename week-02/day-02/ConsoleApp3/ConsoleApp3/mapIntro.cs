using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            if(map.Count == 0)
            {
                Console.WriteLine("Map / Dictionary is empty");
            }
            else Console.WriteLine("Map / Dictionary has " + map.Count + " items");

            Console.WriteLine("------------------------------------------------");

            map.Add(97, "a");
            map.Add(98, "b");
            map.Add(99, "c");
            map.Add(65, "A");
            map.Add(66, "B");
            map.Add(67, "C");

            Console.WriteLine("Addition of 6 elements");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("TO PRINT ALL KEYS");
            foreach (var key in map.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("TO PRINT ALL VALUES");
            foreach (var value in map.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("ADDED NEW VALUE");

            map.Add(68, "D");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("HOW MANY PAIRS?");

            Console.WriteLine("There is: " + map.Count + " pairs in this map");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("TO PRINT VALUE OF 99 KEY?");

            Console.WriteLine(map[99]);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("TO REMOVE VALUE OF 97 KEY?");

            map.Remove(97);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("TO CHECK IF THERE IS ANY 100 KEY AND VALUE TO IT?");

            if(map.ContainsKey(100) == false)
            {
                Console.WriteLine("There is no such key");
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("TO REMOVE ALL");

            map.Clear();
            Console.WriteLine("The map has been cleared");

            Console.ReadLine();
        }

    }
}
