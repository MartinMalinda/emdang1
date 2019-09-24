using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.


            string path = @"C:\Users\dangm\Desktop\test2.txt";                //non existing file
            //string path = @"C:\Users\dangm\Desktop\test.txt";                //existing file == konkrétní cesta 
            //string path = "./my-file.txt";                                      //existing file == (in bin/debug folder)!!!!!

            try
            {
                WordToFileMultipleTimes(path);
            }
            catch (FileNotFoundException)                   // non existing file catch
            {
                Console.WriteLine("Sorry, requested file does not exists!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unable to write to file: " + path);
            }
            //catch (Exception)
            //{
            //    Console.WriteLine("Sorry, something unexpected happened");
            //}
            

            Console.ReadLine();

        }

        public static void WordToFileMultipleTimes(string fileName)
        {
            Console.WriteLine("Please, write your word: ");
            string word = Console.ReadLine();

            Console.WriteLine("How many times would you like the word to be written?: ");
            int count = int.Parse(Console.ReadLine());

            if (!File.Exists(fileName))                                             // ověření, jestli file existuje nebo ne
            {
                Console.WriteLine("This file does not exists!");
            }
            else
            {
                using (StreamWriter writerAppend = File.AppendText(fileName))       // File.AppendText = doplňování textu
                {
                    for (int i = 0; i < count; i++)
                    {
                        writerAppend.WriteLine(word);
                    }
                }
            }

            //using (StreamWriter writer = new StreamWriter(fileName))    // použití streamwriteru - přepsání file odznova
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        writer.WriteLine(word);
            //    }
            //}

            
        }
    }
}
