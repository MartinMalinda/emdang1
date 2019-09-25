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
            BlogPost blogPost1 = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04.");       // object of PostIt class > using custom specified constructor
            BlogPost blogPost2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            BlogPost blogPost3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer " +
                "at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that " +
                "he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            BlogPost blogPost4 = new BlogPost();            // object of PostIt class > using default basic constructor
            blogPost4.AuthorName = "Josef Novák";
            blogPost4.Title = "Dobrý den";
            blogPost4.Text = "Dobrý den - Nashledanou";
            blogPost4.PublicationDate = "1999.01.01";



        }
    }
}
