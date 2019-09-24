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
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.


            //string path = @"C:\Users\dangm\Desktop\test2.txt";                //non existing file
            string path = @"C:\Users\dangm\Desktop\test.txt";                //existing file == konkrétní cesta 
            //string path = "./my-file.txt";                                      //existing file == (in bin/debug folder)!!!!!

            try
            {
                Console.WriteLine(howManyLines(path)); 
            }
            catch (FileNotFoundException)                   // non existing file catch
            {
                Console.WriteLine("Sorry, requested file does not exists!");
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, something unexpected happened");
            }

            Console.ReadLine();

        }

        public static int howManyLines(string fileName)
        {
            int numberOfLines = File.ReadLines(fileName).Count();

            return numberOfLines;
        }

    }
}
