using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBookLibrary.Models
{
    public class Author
    {

        public int AuthorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}