using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendAFunc` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendAFunc(typo)`

            string typo = "Chinchill";
            Console.WriteLine(AppendAFunc(typo));


            Console.ReadKey();
        }

        public static string AppendAFunc(string x)
        {
            x = x + "a";
            return x;
        }

    }
}

