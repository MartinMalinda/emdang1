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
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo



            string todoText = " - Buy milk\n";
            string a = "- Download games";


            Console.WriteLine("Original text:");
            Console.Write(todoText);

            Console.WriteLine("----------------------------");

            //todoText.Insert(13, )
            Console.WriteLine();
            todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(todoText.Length, " - Download games\n");
            todoText = todoText.Insert(todoText.Length, "\t- Diablo");


            Console.Write(todoText);



            Console.ReadLine();
        }


    }
}
