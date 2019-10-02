using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInZoo
{
    class Reptile : Animal
    {
        public Reptile(AnimalType name, GenderType gender)
        {
            Name = name;
            Gender = gender;
        }

        public override void Greet()
        {
            Console.WriteLine("Hi, my name is " + Name + " and my gender is " + Gender);
        }

        public override string WantChild()
        {
            if(Name == AnimalType.Frog)
            {
            return "wants a child from my uterus";
            }
            return "wants a child from egg";

        }

    }
}
