using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PostIt
    {
        public string BackgroundColor { get; set; }             // properties of a class > every object will have them
        public string Text { get; set; }
        public string TextColor { get; set; }

        public PostIt()             // default basic constructor 
        {

        }

        public PostIt(string BackgroundColor, string Text, string TextColor)        // custom specified constructor
        {
            this.BackgroundColor = BackgroundColor;                     // adding the typed values of constructor to the class properties
            this.Text = Text;
            this.TextColor = TextColor;
        }
    }
}
