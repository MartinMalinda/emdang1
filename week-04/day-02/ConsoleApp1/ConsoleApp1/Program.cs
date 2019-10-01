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
            Person Pedro = new Person("Pedro", 10, "male");
            Person Jane = new Person();

            //Pedro.Introduce();
            //Jane.Introduce();

            //Pedro.GetGoal();
            //Jane.GetGoal();

            Student StudentMike = new Student("Mike", 10, "male", "UCLA");
            Student StudentJane = new Student();

            StudentMike.Introduce();
            StudentJane.Introduce();
            StudentMike.GetGoal();
            StudentJane.GetGoal();






            Console.ReadLine();
        }
    }
}
