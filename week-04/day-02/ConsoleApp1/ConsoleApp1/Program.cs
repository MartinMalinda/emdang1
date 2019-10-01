using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Person Pedro = new Person("Pedro", 10, Person.GenderType.Male);
            Person Jane = new Person();

            //Pedro.Introduce();
            //Jane.Introduce();

            //Pedro.GetGoal();
            //Jane.GetGoal();

            //Student StudentMike = new Student("Mike", 10, Person.GenderType.Male, "UCLA");
            //Student StudentJane = new Student();

            //StudentMike.Introduce();
            //StudentJane.Introduce();
            //StudentMike.GetGoal();
            //StudentJane.GetGoal();


            var people = new List<Person>();

            var mark = new Person("Mark", 46, Person.GenderType.Male);
            people.Add(mark);
            var jane = new Person();
            people.Add(jane);
            var john = new Student("John Doe", 20, Person.GenderType.Male, "BME");
            people.Add(john);
            var student = new Student();
            people.Add(student);
            var gandhi = new Mentor("Gandhi", 148, Person.GenderType.Male, Mentor.MentorLevel.Senior);
            people.Add(gandhi);
            var mentor = new Mentor();
            people.Add(mentor);
            var sponsor = new Sponsor();
            people.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, Person.GenderType.Male, "SpaceX");
            people.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            awesome.Info();



            Console.ReadLine();
        }
    }
}
