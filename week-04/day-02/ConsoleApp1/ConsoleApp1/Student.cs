using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays = 0;

        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student() : base()
        {
            PreviousOrganization = "The School Of Life";
        }

        public Student(string name, int age, GenderType gender, string previousOrganization) : base(name, age, gender)
        {
            
            PreviousOrganization = previousOrganization;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + this.Name + ", a " + this.Age + " year old " + this.Gender + " from " + this.PreviousOrganization + 
                " who skipped " + this.SkippedDays + " days from the course already.");
        }

        public int SkipDays (int numberOfDays)
        {
            SkippedDays = SkippedDays + numberOfDays;

            return SkippedDays;
        }
    }
}
