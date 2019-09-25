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
            Animal animal1 = new Animal();
            animal1.Play();
            animal1.Play();
            Console.WriteLine(animal1.Hunger);
            Console.WriteLine(animal1.Thirst);




            Console.Read();

        }
    }
}
