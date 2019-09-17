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
            List<string> names = new List<string>();            //vytvoření listu - musí být deklarována knihovna System.Collections.Generic

            names.Add("Miloš");
            names.Add("Bohouš");
            names.Add("Franta");
            names.Add("William");

            if(names.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else Console.WriteLine("List is not empty");

            Console.WriteLine("---------------------------------------");


            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine("The number of list elements:" + names.Count);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine(names[2]);

            Console.WriteLine("---------------------------------------");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------------------------------------");

            int i = 1;

            foreach (var name in names)
            {
                Console.WriteLine(i + "." + name);
                i++;
            }
            Console.WriteLine("---------------------------------------");

            names.RemoveAt(1);
            Console.WriteLine("Bohouš vymazán");

            Console.WriteLine("---------------------------------------");

            Console.WriteLine(names.Count);
            
            for (int j = names.Count; j >0; j--)
            {
                Console.WriteLine(names[j-1]);          // j-1 protože by to bralo index[5] = 6. prvek
                                                        // je možné akorát dát names.reverse();
            }
            Console.WriteLine("---------------------------------------");

            names.Clear();
            Console.WriteLine("List vyčištěn");
            if(names.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else Console.WriteLine("List is not empty");

            Console.ReadLine();
        }

    }
}
