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
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = new int[5] { 3, 4, 5, 6, 7 };
            int[] bj = new int[5];

            foreach (var num in aj)
            {
                Console.Write(num+" ");
            }

            Console.WriteLine();  // separator

            for (int i = 0; i < aj.Length; i++)         //length 5
            {
                //aj[i] = bj[((aj.Length)-1) - i];
                bj[i] = aj[((aj.Length) - 1) - i];
            }

            foreach (var num1 in bj)
            {
                Console.Write(num1 + " ");
            }

            Console.ReadKey();
        }
    }
}

