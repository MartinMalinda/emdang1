using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] argv)
        {
            Station stationOne = new Station();
            Car carOne = new Car();

            Console.WriteLine("The car's GasAmount is now: " + carOne.GasAmount);
            Console.WriteLine("The station's GasAmount is now: " + stationOne.GasAmount);

            Console.WriteLine();

            stationOne.Refill(carOne, 50);


            Console.WriteLine();

            Console.WriteLine("The car's GasAmount is now: " + carOne.GasAmount);
            Console.WriteLine("The station's GasAmount is now: " + stationOne.GasAmount);

            Console.WriteLine();

            stationOne.Refill(carOne, 60);

            Console.WriteLine("The car's GasAmount is now: " + carOne.GasAmount);
            Console.WriteLine("The station's GasAmount is now: " + stationOne.GasAmount);


            Console.ReadLine();
        }

        
    }

}
