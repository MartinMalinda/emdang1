using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt("Orange", "Idea1", "Blue");         // object of PostIt class > using custom specified constructor
            PostIt postIt2 = new PostIt("Pink", "Awesome", "Black");
            PostIt postIt3 = new PostIt("Yellow", "Superb!", "Green");

            PostIt postIt4 = new PostIt();                              // object of PostIt class > using default basic constructor
            postIt4.BackgroundColor = "Purple";
            postIt4.Text = "Hello";
            postIt4.TextColor = "White";


        }
    }
}
