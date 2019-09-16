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
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output


            int[,] multiArray = new int[4,4];
            Console.WriteLine(multiArray.Length);
            
            for (int i = 0; i < Math.Sqrt(multiArray.Length); i++) // zapis loop
            {
                multiArray[i,i] = 1;
            }
            
            for (int j = 0; j < Math.Sqrt(multiArray.Length); j++) // row loop
            {
                for (int k = 0; k < Math.Sqrt(multiArray.Length); k++) // column loop
                {
                    Console.Write(multiArray[j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
