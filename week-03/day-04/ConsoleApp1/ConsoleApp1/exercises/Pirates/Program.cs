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
            Pirate pirateOne = new Pirate("One");
            Pirate pirateTwo = new Pirate("Two");
            Pirate pirateThree = new Pirate("Three");
            Pirate pirateFour = new Pirate("Four");

            pirateOne.DrinkSomeRum();
            pirateOne.DrinkSomeRum();
            pirateOne.DrinkSomeRum();
            pirateOne.DrinkSomeRum();
            pirateOne.DrinkSomeRum();
      

            pirateTwo.HowsItGoingMate();
            pirateThree.Die();
            Console.WriteLine($"Pirate {pirateThree.Name} dead status: {pirateThree.IsDead}");

            Console.WriteLine();
            pirateOne.Brawl(pirateTwo);

            Console.WriteLine($"Pirate {pirateOne.Name} dead status: {pirateOne.IsDead}");
            Console.WriteLine($"Pirate {pirateTwo.Name} dead status: {pirateTwo.IsDead}");


            Console.Read();
        }
    }

}
