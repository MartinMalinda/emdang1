using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {

        public void Learn()
        {
            Console.WriteLine("I am learning something new!");
        }

        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
