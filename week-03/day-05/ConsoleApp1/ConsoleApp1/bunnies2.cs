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
            Console.WriteLine("Hello user, please type how many bunnies you have: ");
            int bunnies = int.Parse(Console.ReadLine());
            Console.WriteLine("The amount of bunnies you have is: " + bunnies);
            Console.WriteLine("And the amount of fluffy ears is: " + BunnyEars(bunnies));
            
            Console.ReadKey();
        }


        public static int BunnyEars(int amountOfBunnies)
        {
            if (amountOfBunnies == 0)
            {
                return 0;
            }
           else if(amountOfBunnies == 1)
            {
                return 2;
            }
           else if (amountOfBunnies % 2 != 0)
            {
                return 2 + BunnyEars(amountOfBunnies - 1);
            }
            else
            {
                return 3 + BunnyEars(amountOfBunnies - 1);
            }
            
        }   
    }

}
