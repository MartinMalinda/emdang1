using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> map = new Dictionary<string, string>();
            map.Add("978-1-60309-452-8", "A Letter to Jo");
            map.Add("978-1-60309-459-7", "Lupus");
            map.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            map.Add("978-1-60309-461-0", "The Lab");

            Console.WriteLine("-------------vypsání v daném formátu------------------------");
            Console.WriteLine();


            foreach (var item in map)
            {
                Console.WriteLine(item.Value + " (" + item.Key + ")");
            }

            Console.WriteLine("----------------vymazání jednoho paru dle key a vypsání--------------");
            Console.WriteLine();


            map.Remove("978-1-60309-444-3");
            foreach (var item in map)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------vymazani jednoho paru dle value a vypsani-----------");
            Console.WriteLine();


            foreach (var item in map)
            {
                if (item.Value == "The Lab")
                {
                    map.Remove(item.Key);
                    break;
                }
                
            }

            foreach (var item in map)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------přidání nových pairs a vypsáni-----------");
            Console.WriteLine();

            map.Add("978-1-60309-450-4", "They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            foreach (var item in map)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------zjistěni jestli je k danému klíči nějaká value-----------");
            Console.WriteLine();


            if (map.ContainsKey("478-0-61159-424-8") == true)
            {
                Console.WriteLine("YES, this dictionary has a value associated with \"478-0-61159-424-8\" key");
            }
            else Console.WriteLine("NO, this dictionary doesnt have a value associated with \"478-0-61159-424-8\" key");

            Console.WriteLine("-----------------vypsání value klíče 978-1-60309-453-5 -----------");
            Console.WriteLine();

            Console.WriteLine(map["978-1-60309-453-5"]);

            Console.ReadLine();
        }
    }
}
