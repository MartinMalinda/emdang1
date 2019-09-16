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
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`

            int[] ai = new int[5] { 3, 4, 5, 6, 7 };

            Console.WriteLine(ai.Length);

            int sum1 = 0;
            for (int i = 0; i < ai.Length; i++)
            {
                sum1 = sum1 + ai[i];
            }

            Console.WriteLine(sum1);
            Console.WriteLine();

            int sum2 = 0;
            foreach (int num in ai)
            {
                sum2 = sum2+num;
            }
            Console.WriteLine(sum2);

            Console.ReadKey();
        }
    }
}

