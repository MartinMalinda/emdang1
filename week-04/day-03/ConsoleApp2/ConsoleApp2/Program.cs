using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student john = new Student("John Doe", 20, Person.GenderType.Male, "BME");
            Student john2 = john.Clone() as Student;

            students.Add(john);
            students.Add(john2);

            foreach (var student in students)
            {
                student.Introduce();
            }

            Console.ReadLine();
        }
    }
}
