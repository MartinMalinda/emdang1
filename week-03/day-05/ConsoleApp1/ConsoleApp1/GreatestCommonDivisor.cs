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
            Console.WriteLine("Hello user, please type the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello user, please type the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("The greatest divisor of the given numbers is: ");
            Console.Write(GreatestDivisor(num1, num2));
            Console.ReadKey();
        }


        public static int GreatestDivisor(int numberOne, int numberTwo)
        {
            if (numberOne < numberTwo)
            {
                (numberOne, numberTwo) = (numberTwo, numberOne);
            }
            
            if ((numberOne % numberTwo) == 0)
            {
                return numberTwo;
            }
            else
            {
                return GreatestDivisor(numberTwo, (numberOne % numberTwo));
            }
            


            //if (numberOne < numberTwo)
            //{
            //    (numberOne, numberTwo) = (numberTwo, numberOne);
            //}
            //else
            //{
            //    if ((numberOne % numberTwo) == 0)
            //    {
            //        return numberTwo;
            //    }
            //    else
            //    {
            //        return GreatestDivisor(numberTwo, (numberOne%numberTwo));
            //    }

            //}
        }
    }

}
