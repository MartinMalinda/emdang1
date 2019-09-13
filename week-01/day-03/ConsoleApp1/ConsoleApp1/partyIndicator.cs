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
            string checkin = "yes";

            do
            {
                Console.WriteLine("How many girls are at the party?: ");
                int girls = int.Parse(Console.ReadLine());

                Console.WriteLine("How many boys are at the party?: ");
                int boys = int.Parse(Console.ReadLine());

                int partyPeople = girls + boys;


                if ((girls == boys) && partyPeople > 20)
                {
                    Console.WriteLine("The party is excellent!");
                }
                else if (partyPeople > 20 && girls != boys)
                {
                    Console.WriteLine("Quite cool party!");

                }
                else if (girls == 0)
                {
                    Console.WriteLine("Sausage party");

                }
                else Console.WriteLine("Average party...");

                Console.WriteLine("You want to play again? (yes/no)");
                checkin = Console.ReadLine();
                Console.WriteLine();

            } while (checkin == "yes");
            

            Console.ReadLine();


            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
        }
    }
}

