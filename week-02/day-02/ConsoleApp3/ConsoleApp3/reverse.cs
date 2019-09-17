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
            //Console.WriteLine(".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI");
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));
            //Reverse(reversed);                            // při vypsání only

            Console.ReadLine();
        }

        public static string Reverse(string originalText)
        {

            char[] charArray = originalText.ToCharArray();
            Array.Reverse(charArray);
            string joinedReversedString = string.Join("", charArray);

            return joinedReversedString;

            /*foreach (var character in charArray)          //vypsání - není potřeba return
            {
                Console.Write(character);

            }*/

        }

    }
}
