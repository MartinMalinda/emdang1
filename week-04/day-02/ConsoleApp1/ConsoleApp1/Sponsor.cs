using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public string Company { get; private set; }
        public int HiredStudents { get; private set; }

        public Sponsor() : base()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public Sponsor(string name, int age, GenderType gender, string company) : base(name, age, gender)
        {
            Company = company;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + this.Name + ", a " + this.Age + " year old " + this.Gender + " who represents " + this.Company +
                " and hired " + this.HiredStudents + " students so far.");
        }

        public void Hire()
        {
            HiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }


    }
}
