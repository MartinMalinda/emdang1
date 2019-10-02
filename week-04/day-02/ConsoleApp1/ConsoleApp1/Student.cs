using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    // added the IClonable interface
    class Student : Person, ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student() : base()
        {
            PreviousOrganization = "The School Of Life";
            SkippedDays = 0;
        }

        public Student(string name, int age, GenderType gender, string previousOrganization) : base(name, age, gender)
        {
            
            PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer");
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
