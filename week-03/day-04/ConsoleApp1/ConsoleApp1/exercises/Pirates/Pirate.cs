using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pirate
    {

        public string Name;
        public int DrunkCounter { get; set; }
        public bool IsDead = false;

        public Pirate(string name)
        {
            Name = name;
        }

        public void DrinkSomeRum()
        {
            DrunkCounter++;
            Console.WriteLine("The pirate " + this.Name + " had drunk some rum");
        }

        public void HowsItGoingMate()
        {
            if (DrunkCounter >= 0 && DrunkCounter <= 4)
            {   
                Console.WriteLine("Pour me annuder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                Console.WriteLine("Pirate has just passed out right now");
            }
        }

        public void Die()
        {
            if (IsDead == true)
            {
                Console.WriteLine("Bruh, the pirate is dead already... ");
            }
            else
            {
                IsDead = true;
            }
        }

        public void Brawl(Pirate otherPirate)
        {
            Random random = new Random();
            int randomValue = random.Next(1, 4); // "4" because "3" needs to be included

            if(otherPirate.IsDead == true)
            {
                Console.WriteLine("You cant fight a dead guy bruh... ");
            }
            else
            {
                switch (randomValue)
                {
                    case 1:
                        {
                            otherPirate.Die();
                            Console.WriteLine("The other pirate known as " + otherPirate.Name + " has just died");
                            break;
                        }

                    case 2:
                        {
                            this.IsDead = true;
                            Console.WriteLine("Your pirate known as " + this.Name + " has just died");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("They both passed out");
                            break;
                        }
                    default:
                        Console.WriteLine("Something is not right");
                        break;
                }

            }



        }
    }

    
}
