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
            Dictionary<string,string> telephoneBook = new Dictionary<string,string>();     //list se zadanými expenses

            telephoneBook.Add("William A. Lathan", "405-709-1865");
            telephoneBook.Add("John K. Miller", "402-247-8568");
            telephoneBook.Add("Hortensia E. Foster", "606-481-6467");
            telephoneBook.Add("Amanda D. Newland", "319-243-5613");
            telephoneBook.Add("Brooke P. Askew", "307-687-2982");

            Console.WriteLine("---------------TelephoneBook---------------");
            Console.WriteLine();

            Console.WriteLine("---------------TelNumber of J.K.Miller---------------");
            Console.WriteLine("Phone number of J.K.Miller is: " + telephoneBook["John K. Miller"]);
            Console.WriteLine();

            foreach (var item in telephoneBook)
            {
                if (item.Value == "307-687-2982")
                {
                    Console.WriteLine("The number \"307 - 687 - 2982\" belongs to: " + item.Key);
                    break;
                }
            }
            Console.WriteLine("---------------Chris E. Myer' telephone?---------------");

           

            foreach (var item in telephoneBook)
            {
                if (item.Key == "Chris E.Myer")
                {
                    Console.WriteLine("YES, the number of Chris is: " + item.Value);
                    break;
                }
                
            }









            Console.ReadLine();
        }
    }
}
