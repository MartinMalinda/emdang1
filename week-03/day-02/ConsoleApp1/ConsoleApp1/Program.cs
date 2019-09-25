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
            // Create a method that decrypts the duplicated-chars.txt 

            string path1 = @"C:\Users\dangm\Desktop\test.txt";                 
            string path2 = @"C:\Users\dangm\Desktop\test2.txt";                
            //string path = "./my-file.txt";                                      //existing file == (in bin/debug folder)!!!!!

            
                ToDecrypt(path1, path2);
            

            Console.ReadLine();
        }

        public static void toDecrypt(string fileName1, string fileName2)
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
                    for (int i = 0; i < (content.Length); i++)
                    {
                        for (int j = 0; j < content[i].Length; j++)
                        {
                            //char[] charArray = content[i].ToCharArray();
                            StringBuilder sb = new StringBuilder(content[i]);
                            sb.Remove(j + 1, 1);
                            sb.ToString();
                        }
                        

                        
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("The copy proces status: " + result);
                }
            }
             
        }
    }
}
