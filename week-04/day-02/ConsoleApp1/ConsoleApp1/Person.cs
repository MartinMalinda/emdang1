using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;
        private GenderType gender;

        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public enum GenderType
        {
            Male,
            Female
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = GenderType.Female;
        }

        //defining the gender type enum
        public Person(string name, int age, GenderType gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm " + this.Name + ", a " + this.Age + " year old " + this.Gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }


    }
} 
