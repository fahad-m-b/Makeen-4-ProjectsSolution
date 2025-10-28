using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Project2.Models
{
    public class Book
    {
        public Book(string title)
        {
            Title = title;
            IsBorrowed = false;
        }

        public string Title { get; set; }
        public bool IsBorrowed { get; set; }
    }
}
