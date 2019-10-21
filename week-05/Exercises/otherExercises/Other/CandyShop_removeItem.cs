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
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Sweets(list);
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
            Console.ReadLine();
        }

        public static List<object> Sweets(List<object> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is string)
                {
                    continue;
                }
                else
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            return list;
        }
    }
}
