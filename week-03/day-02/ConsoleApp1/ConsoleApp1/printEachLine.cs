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
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"



            //string path = @"C:\Users\dangm\Desktop\test2.txt";                //non existing file
            //string path = @"C:\Users\dangm\Desktop\test.txt";                //existing file == konkrétní cesta 
            string path = "./my-file.txt";                                      //existing file == (in bin/debug folder)!!!!!

            try
            {
                Console.WriteLine(File.ReadAllText(path));
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

    }
}
