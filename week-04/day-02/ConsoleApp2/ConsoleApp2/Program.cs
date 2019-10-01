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

            Aircraft plane = new Aircraft();
            F16 concord = new F16();

            Console.WriteLine(concord.GiveType());
            concord.GetStatus();
            Console.WriteLine(concord.IsPriority());

            Console.WriteLine();

            F35 gripen = new F35();
            Console.WriteLine(gripen.GiveType());
            gripen.GetStatus();
            Console.WriteLine(gripen.IsPriority());


            Console.ReadLine();
        }
    }
}
