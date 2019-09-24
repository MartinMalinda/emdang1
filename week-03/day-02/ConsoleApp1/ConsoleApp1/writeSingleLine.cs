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
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"


            //string path = @"C:\Users\dangm\Desktop\test2.txt";                //non existing file
            string path = @"C:\Users\dangm\Desktop\test.txt";                //existing file == konkrétní cesta 
            //string path = "./my-file.txt";                                      //existing file == (in bin/debug folder)!!!!!

            try
            {
                WriteInFile(path, "Martin Dang");
            }
            catch (FileNotFoundException)                   // non existing file catch
            {
                Console.WriteLine("Sorry, requested file does not exists!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unable to write to file: " + path);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, something unexpected happened");
            }

            Console.ReadLine();

        }

        public static void WriteInFile(string fileName, string input)
        {
            File.WriteAllText(fileName, input);                 //WriteAllText = přepíše celý soubor
        }

    }
}
