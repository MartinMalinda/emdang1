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
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string path1 = @"C:\Users\dangm\Desktop\test.txt";                 
            string path2 = @"C:\Users\dangm\Desktop\test2.txt";                
            //string path = "./my-file.txt";                                      //existing file == (in bin/debug folder)!!!!!

            //try
            //{
                copyTextToOtherFile(path1, path2);
            //}
            //catch (FileNotFoundException)                   // non existing file catch
            //{
            //    Console.WriteLine("Sorry, requested file does not exists!");
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine("Unable to write to file: " + path);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Sorry, something unexpected happened");
            //}

            Console.ReadLine();
        }

        public static void copyTextToOtherFile(string fileName1, string fileName2)
        {
            Boolean result = false;
            if(!File.Exists(fileName1) || !File.Exists(fileName2))
            {
                Console.WriteLine("One of the files does not exists!");
                Console.WriteLine("The copy proces status: " + result);
            }
            else
            {
                try
                {
                    string[] content = File.ReadAllLines(fileName1);
                    File.WriteAllLines(fileName2, content);
                    result = true;
                    Console.WriteLine("The copy proces status: " + result);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("The copy proces status: " + result);
                }
            }
             
        }
    }
}
