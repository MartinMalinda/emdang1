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
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6

            DiceSet diceSet = new DiceSet();
            RollSixOnly(diceSet);

            Console.ReadLine();
        }

        public static void RollSixOnly(DiceSet diceSetOne)
        {
            Console.WriteLine("THE FIRST DEFAULT THROWS OF ALL DICES");
            diceSetOne.Roll();

            foreach (var singleDiceDefault in diceSetOne.GetCurrent())
            {
                Console.Write(singleDiceDefault + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int i = 0;
            foreach (var singleDice in diceSetOne.GetCurrent())
            {
                while (diceSetOne.GetCurrent(i) != 6)
                {
                    Console.WriteLine((i + 1) + ". dice re-rolled");
                    diceSetOne.Reroll(i);
                    Console.WriteLine("  re-rolled value: " + diceSetOne.GetCurrent(i));
                }
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("THE EDITED THROWS OF ALL DICES (ONLY NON \"6\" DICES");

            foreach (var singleDiceRerolled in diceSetOne.GetCurrent())
            {
                Console.Write(singleDiceRerolled + " ");
            }

        }
    }

}
