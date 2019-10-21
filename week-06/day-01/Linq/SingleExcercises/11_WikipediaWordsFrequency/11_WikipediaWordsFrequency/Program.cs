using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_WikipediaWordsFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./textFile.txt";

            string allText = File.ReadAllText(path).ToLower();
            for (int i = 0; i < allText.Length; i++)
            {
                if((allText[i] > 122 || allText[i] < 97 ) && allText[i] != 32)
                {
                    allText = allText.Remove(i, 1);
                    i--;
                    //allText = allText.Replace(allText[i], ' ');

                }
            }
            char[] separators = { ' ', '\r', '\n'};
            string[] wordArr = allText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
