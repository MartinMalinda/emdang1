using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarsystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputPath = "./reversed.txt";
            string outputPath = "./resultReversed.txt";

            DecryptFile(inputPath, outputPath);

            Console.ReadLine();
        }

        public static void DecryptFile(string input, string output)
        {
            string[] originalText = File.ReadAllLines(input);
            List<string> fixedText = new List<string>();
            for (int i = 0; i < originalText.Length; i++)
            {
                fixedText.Add(ReverseString(originalText[i]));

                //fixedText[i] = originalText[i];
                //fixedText[i] = fixedText[i].Reverse();    // why it is not working?
            }

            Console.WriteLine("The file has been decrypted.");

            File.AppendAllLines(output, fixedText);
        }

        public static string ReverseString(string s)
        {
            char[] tempArr = s.ToCharArray();
            Array.Reverse(tempArr);
            string finalText = new string(tempArr);
            return finalText;
        }
    }
}
