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
            string inputPath = "./reversedOrder.txt";
            string outputPath = "./resultReversedOrder.txt";

            DecryptFile(inputPath, outputPath);

            Console.ReadLine();
        }

        public static void DecryptFile(string input, string output)
        {
            string[] originalText = File.ReadAllLines(input);
            string[] fixedText = new string[originalText.Length];

            int position = originalText.Length-1;
            for (int i = 0; i < originalText.Length; i++)
            {
                fixedText[i] = originalText[position];
                position--;
            }

            Console.WriteLine("The file has been decrypted.");

            foreach (var item in fixedText)
            {
                Console.WriteLine(item);
            }


            File.WriteAllLines(output, fixedText);
        }
    }
}
