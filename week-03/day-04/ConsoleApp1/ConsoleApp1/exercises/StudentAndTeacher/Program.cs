using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] argv)
        {
            Teacher teacherOne = new Teacher();
            Student studentOne = new Student();

            studentOne.Question(teacherOne);
            teacherOne.Teach(studentOne);

            Console.ReadLine();
        }

        
    }

}
