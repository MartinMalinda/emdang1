using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BlogPost
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublicationDate { get; set; }

        public BlogPost()
        {

        }

        public BlogPost(string AuthorName, string Title, string Text, string PublicationDate)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }

    }

    
}
