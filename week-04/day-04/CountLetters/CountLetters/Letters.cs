using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class Letters
    {
        public Letters()
        {

        }

        public void CountLettersMethod(string word)
        {
            //// declaring a dictionary for the result
            //Dictionary<char, int> dictionary = new Dictionary<char, int>();

            //// transforming string into charArray
            //char[] charArray = word.ToCharArray();

            //// list for storing occurences
            //List<int> occurList = new List<int>();

            //// counter for occurencies
            //int counter = 1;

            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    for (int j = i; j < charArray.Length; j++)
            //    {
            //        if (charArray[j] == charArray[i])
            //        {
            //            counter++;
            //        }
            //        //dictionary.Add()
            //        occurList.Add(counter);
            //    }
            //}

            //foreach (var item in occurList)
            //{
            //    Console.WriteLine(item);
            //}

            
            char[] charArray = word.ToLower().ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            //int tempVar = 0;
            foreach (var item in charArray)
            {
                if (dictionary.ContainsKey(item))
                {
                    //dictionary[item] += 1;
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(string.Format(item.Key + ": " + item.Value + " times"));
            }


        }
    }
}
