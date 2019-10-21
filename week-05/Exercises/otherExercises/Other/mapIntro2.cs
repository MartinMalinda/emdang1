using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarsystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("978-1-60309-452-8", "A Letter to Jo");
            map.Add("978-1-60309-459-7", "Lupus");
            map.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            map.Add("978-1-60309-461-0", "The Lab");

            // printing all key-value pairs in given format
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Value} (ISBN: {item.Key})");
            }

            Console.ReadLine();

            // removing a pair through key
            map.Remove("978-1-60309-444-3");
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Value} (ISBN: {item.Key})");
            }
            Console.ReadLine();

            // removing a pair through value  
            string theKey = "";
            foreach (var item in map)
            {
                if (item.Value == "The Lab")
                {
                    theKey = item.Key;
                }
            }
            map.Remove(theKey);

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Value} (ISBN: {item.Key})");

            }
            Console.ReadLine();

            // adding new key-par elements
            map.Add("978-1-60309-450-4", "They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            Console.WriteLine("Added new elements");
            Console.ReadLine();

            // verifying if theres a value associated with give key 
            if (map.ContainsKey("478-0-61159-424-8") == true)
            {
                Console.WriteLine("Map dictionary contains key: 478-0-61159-424-8");
            }
            else
            {
                Console.WriteLine("Map dictionary doesnt contain key: 478-0-61159-424-8");

            }
            Console.ReadLine();

            // verifying if theres a value associated with give key 
            foreach (var item in map)
            {
                if(item.Key == "978-1-60309-453-5")
                {
                    Console.WriteLine(item.Value);
                }
            }

            Console.ReadLine();
        }

    }
}
