using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInZoo
{
    class Mammal : Animal
    {
        private int milkAmount;

        public int MilkAmount { get; set; }

        public Mammal(AnimalType name, GenderType gender)
        {
            Name = name;
            Gender = Gender;
            MilkAmount = 2;
        }

        public override void Greet()
        {
            Console.WriteLine("Hi, my name is " + Name + " and my gender is " + Gender + ". My milk amount is " + MilkAmount +" l");
        }

        public override string WantChild()
        {
            return "wants a child from my uterus";
        }
    }
}
