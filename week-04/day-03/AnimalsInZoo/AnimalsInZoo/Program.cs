using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var crocodile = new Reptile(Animal.AnimalType.Crocodile, Animal.GenderType.Female);
            var frog = new Reptile(Animal.AnimalType.Frog, Animal.GenderType.Female);
            var mammal = new Mammal(Animal.AnimalType.Koala, Animal.GenderType.Female);
            var bird = new Bird(Animal.AnimalType.Bird, Animal.GenderType.Male);

            crocodile.Greet();
            frog.Greet();
            mammal.Greet();
            bird.Greet();

            Console.WriteLine();

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(crocodile.Name + ", " + crocodile.WantChild());
            Console.WriteLine(frog.Name + ", " + frog.WantChild());
            Console.WriteLine(mammal.Name + ", " + mammal.WantChild());
            Console.WriteLine(bird.Name + ", " + bird.WantChild());

            Console.ReadLine();
        }
    }
}
