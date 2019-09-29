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
           // int[] arrayOfNumbers = { 1, 5, 20, 3, 50, 45 };
            int[] arrayOfNumbers = { 1, 5};

            Console.WriteLine("Array of numbers created");
            Console.WriteLine("The maximum number of the given array is: " + MaximumFinder(arrayOfNumbers));

            Console.ReadKey();
        }


        public static int MaximumFinder(int[] array)   // I want a method with only array as an argument, not n etc. 
        {
            int lenght = array.Length;
            if(lenght == 1)
            {
                return array[0];

            }else
            {
                return Math.Max(array[0], MaximumFinder(array - 1));
            }


            //else if(array.Length > 1){

            //    if(array[0] > array[1])
            //    {
            //        return array[0];
            //    }
            //    return array[1];

            //} return 0;

           // if (amountOfBunnies == 0)
           // {
           //     return 0;
           // }
           //else if(amountOfBunnies == 1)
           // {
           //     return 2;
           // }
           //else if (amountOfBunnies % 2 != 0)
           // {f
           //     return 2 + BunnyEars(amountOfBunnies - 1);
           // }
           // else
           // {
           //     return 3 + BunnyEars(amountOfBunnies - 1);
           // }
            
        }   
    }

}
