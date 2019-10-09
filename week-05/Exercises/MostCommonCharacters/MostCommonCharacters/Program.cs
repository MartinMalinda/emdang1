using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./textFile.txt";

            MostCommonChar(path);
            

            Console.ReadLine();
        }

        public static void MostCommonChar(string path)
        {
            try
            {
                string wholeText = File.ReadAllText(path); // reading the text into string
                wholeText = wholeText.ToLower();
                wholeText = wholeText.Replace(" ", "");     // removing spaces
                wholeText = wholeText.Replace(Environment.NewLine, "");     // removing newlines

                Dictionary<char, int> dictionary = new Dictionary<char, int>(); // declaring the dictionary

                for (int i = 0; i < wholeText.Length; i++)
                {
                    if (dictionary.ContainsKey(wholeText[i]))       // adding occurences to an existing key
                    {
                        dictionary[wholeText[i]]++;
                    }
                    else
                    {
                        dictionary.Add(wholeText[i], 1);        // first occurence of the individual char
                    }
                }

                var orderedDictionary = dictionary.OrderByDescending(item => item.Value).Take(2);
                //orderedDictionary = orderedDictionary.Take(2); // not possible on list, but only on IEnumerable > its returned through ".orderbydescending"   

                foreach (var item in orderedDictionary)            // cycling through the dictionary
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File does not exists!");
            }
        }
    }
}
