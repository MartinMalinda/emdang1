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
            string inputPath = "./doubled.txt";
            string outputPath = "./result.txt";

            DecryptFile(inputPath, outputPath);

            Console.ReadLine();
        }

        public static void DecryptFile(string input, string output)
        {
            string originalText = File.ReadAllText(input);

            int size = originalText.Length;
            char[] fixedTextArr = new char[size];
            
            int position = 0;
            for (int i = 0; i < originalText.Length; i += 2)
            {
                fixedTextArr[position] = originalText[i];
                position++;
            }

            string final = new string(fixedTextArr);
            Console.WriteLine("The file has been decrypted.");
            File.WriteAllText(output, final);

            //Console.WriteLine(final);
        }
    }
}
