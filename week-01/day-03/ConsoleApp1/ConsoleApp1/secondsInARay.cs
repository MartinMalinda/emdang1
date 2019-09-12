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
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int daySeconds = 86400;
            int currentTimeSecondsPassed = ((currentHours * 3600) + (currentMinutes * 60) + currentSeconds);
            int secondsLeft = daySeconds - currentTimeSecondsPassed;
            Console.WriteLine(secondsLeft + " seconds left");
            Console.ReadLine();

            // 50400 - hours
            // 2040 - minutes
            // 42 - seconds
            // 52 482 celkem seconds passed 
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
        }
    }
}

