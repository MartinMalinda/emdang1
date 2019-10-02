using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInZoo
{
    class Bird : Animal
    {
        private int numberOfFeathers;
        private int flyMileage;

        public int NumberOfFeathers { get; set; }
        public int FlyMileage { get; set; }


        public Bird(AnimalType name, GenderType gender)
        {
            Name = name;
            Gender = gender;
            NumberOfFeathers = 300;
        }

        public override void Greet()
        {
            Console.WriteLine("Hi, my name is " + Name + " and my gender is " + Gender + ". I also have " + NumberOfFeathers + " feathers and flew " + FlyMileage + " Km");
        }

        public override string WantChild()
        {
            return "wants a child from an egg";
        }
    }
}
