using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher
    {
        public void Teach(Student student)
        {
            student.Learn();
        }

        public void Answer()
        {
            Console.WriteLine("I am answering the Student's question!");
        }
    }
}
