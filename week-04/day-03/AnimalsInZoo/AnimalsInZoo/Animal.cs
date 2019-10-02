using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInZoo
{
    abstract class Animal
    {
        public AnimalType Name { get; protected set; }
        public int Age { get; protected set; }
        public GenderType Gender { get; protected set; }

        public enum GenderType
        {
            Male, 
            Female
        }

        public enum AnimalType
        {
            Crocodile, 
            Frog, 
            Koala, 
            Bird
        }

        public abstract void Greet();

        public abstract string WantChild();




    }
}
