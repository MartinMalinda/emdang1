using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Station
    {
        public double GasAmount { get; private set; } = 1000;
        
        public Station()
        {

        }

        public void Refill(Car car, double fuelAmount)
        {
            if((car.GasAmount+fuelAmount) > car.Capacity)
            {
                Console.WriteLine("The refill process was FAILED");
                Console.WriteLine("Your car can only hold " + car.Capacity + " liters of fuel!!!");
            }
            else
            {
                car.GasAmount = car.GasAmount + fuelAmount;
                GasAmount = GasAmount - car.GasAmount;
                Console.WriteLine("The refill process was SUCCESS");
                Console.WriteLine("The car's GasAmount has been filled and also the Station's GasAmount has decreased");

            }

        }
    }
}
