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
            List<int> expenses = new List<int> { 500, 1000, 1250, 175, 800, 120 };      //list se zadanými expenses

            Console.WriteLine("---------------Personal expenses---------------");
            Console.WriteLine();

            int sumOfExpenses = 0;
            int avg = 0;


            foreach (int item in expenses)
            {
                sumOfExpenses += item;
            }

            avg = sumOfExpenses / (expenses.Count);
            Console.WriteLine("In total we spent:" + sumOfExpenses);
            Console.WriteLine("The most expensive thing costed: " + expenses.Max());
            Console.WriteLine("The cheapest thing costed: " + expenses.Min());
            Console.WriteLine("The average of our spendigs is: " + avg);





            Console.ReadLine();
        }
    }
}
