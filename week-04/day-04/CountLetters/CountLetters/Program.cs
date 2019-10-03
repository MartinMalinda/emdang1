using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string test = "Lalalo";
            string test = "La la lo";
            Letters letter = new Letters();

            letter.CountLettersMethod(test);

            Console.ReadLine();
        }
    }
}
