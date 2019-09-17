using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListA = new List<string>() { "apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            //fruit.addRange(new string[] {"avocado", "carrot"....} // další způsob zadávání elementů rychleji

            //List<string> ListB = new List<string>() { "apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> ListB = new List<string>();
            ListB.AddRange(ListA);              // klonovací trik ... kdyby ListB = ListA, tak jsou stejné hodnoty furt (remove atd.)

            Console.WriteLine("This is originial List A");
            foreach (var fruit in ListA)
            {
                Console.WriteLine(fruit);
            }
          
                Console.WriteLine();
            

            Console.WriteLine("This is originial List B");
            foreach (var fruit in ListB)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();

            if (ListA.Contains("Durian")){
                Console.WriteLine("The List A contains DURIAN");
            }
            else
            {
                Console.WriteLine("No durian here ");
            }


            ListB.RemoveAt(3);

            if (ListA.Contains("Durian"))
            {
                Console.WriteLine("The List A contains DURIAN");
            }else
            {
                Console.WriteLine("No durian here ");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");


            foreach (var fruit in ListB)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Adding KIWI to ListA as a 5th element");
            ListA.Insert(4, "Kiwifruit");

            Console.WriteLine();

            foreach (var fruit in ListA)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");

            if (ListA.Count > ListB.Count)
            {
                Console.WriteLine("ListA is bigger");
            }
            else Console.WriteLine("List B is bigger");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("The index of \"Avocado\" is: " + ListA.IndexOf("Avocado"));
            Console.WriteLine("The index of \"Durian\" is: " + ListB.IndexOf("Durian"));   // -1 = value tam není 

            ListB.AddRange(new string[] { "Passion fruit", "Pomelo" });

            foreach (var fruit in ListB)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine(ListA[2]);


            Console.ReadLine();
        }

    }
}
