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
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bmi = massInKg / (heightInM * heightInM);

            Console.WriteLine("The BMI is: " + bmi);
            Console.ReadLine();
        }
    }
}

