using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{

    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            Fleet fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            
            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));


            fleet.getThings()[2].Complete();
            fleet.getThings()[3].Complete();

            Console.WriteLine(fleet.getThings()[0].GetCompletedStatus());
            Console.WriteLine(fleet.getThings()[2].GetCompletedStatus());
            Console.WriteLine();
            int i = 0;
            foreach (var thing in fleet.getThings())
            {
                if(fleet.getThings()[i].GetCompletedStatus() == true)
                {
                    //PrintThings(i, "X", fleet.getThings()[i].getThingName());
                    Console.WriteLine($"{i+1}. [X] {fleet.getThings()[i].getThingName()}");
                }
                else
                {
                    Console.WriteLine($"{i+1}. [ ] {fleet.getThings()[i].getThingName()}");
                }
                i++;
            }
            Console.ReadLine();
            
        }

        public void PrintThings(int count, string completed, string nameOfThing)
        {
            //Console.WriteLine($"{count + 1}. [{completed}] {nameOfThing}");
            //Console.WriteLine($"{count + 1}. [X] {fleet.getThings()[i].getThingName()}");
        }
    }
}
