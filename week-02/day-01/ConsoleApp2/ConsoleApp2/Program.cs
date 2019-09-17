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
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            // Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            // Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'


            for (int i = 0; i < length; i++)
            {

            }


            Console.Write("Please write the end-number: ");
            int endNumber = int.Parse(Console.ReadLine());
            Console.Write("The sum of the number from 0 to your end number is: ");
            Console.Write(factorial(endNumber));

            Console.ReadKey();
        }

        public static int factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <=x; i++)
            {
                result = result * i;
            }
            return result;
        }

    }
}

