using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            TestObject testObject = new TestObject();
            Console.WriteLine("Hello User, please type your first word: ");
            string stringOne = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello User, please type your second word: ");
            string stringTwo = Console.ReadLine();
            Console.WriteLine(testObject.IsAnagram(stringOne, stringTwo));
            Console.ReadLine();
        }
    }

    public class TestObject
    {

        public TestObject()
        {

        }

        public bool IsAnagram(string stringOne, string stringTwo)
        {
            bool result = false;

            char[] arrayOne = stringOne.ToLower().ToCharArray();
            char[] arrayTwo = stringTwo.ToLower().ToCharArray();

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            string stringOneSorted = new string(arrayOne);
            string stringTwoSorted = new string(arrayTwo);

            if (stringOneSorted == stringTwoSorted)
            {
                result = true;
                
            }

            return result;
        }
    }
}
        