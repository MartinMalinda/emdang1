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
            string name = "Martin Dang";
            int age = 300;
            double height = 1.75;
            bool isMarried = false;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("My height: " + height + " meters");
            Console.WriteLine("Married status: " + isMarried);

            Console.ReadLine();


        }
    }
}

// Define several things as a variable then print their values
// Your name as a string
// Your age as an integer
// Your height in meters as a double
// Whether you are married or not as a boolean
