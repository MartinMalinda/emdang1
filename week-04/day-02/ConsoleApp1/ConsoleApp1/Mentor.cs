using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mentor : Person
    {
        private MentorLevel level;
        public MentorLevel Level {get; set;}

        //defining the mentor level 
        public enum MentorLevel
        {
            Junior,
            Intermediate,
            Senior
        }

        public Mentor() : base()
        {
            Level = MentorLevel.Intermediate;
        }

        public Mentor(string name, int age, GenderType gender, MentorLevel level) : base (name, age, gender)
        {
            Level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + this.Name + ", a " + this.Age + " year old " + this.Gender + " " + this.Level +" mentor.");
        }
    }
}
