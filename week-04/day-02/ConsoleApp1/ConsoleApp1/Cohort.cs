using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public string Name { get; private set; }

        public Cohort(string name)
        {
            Name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("The " + Name + " cohort has " + students.Count + " students and " + mentors.Count + " mentors.");
        }
    }
}
