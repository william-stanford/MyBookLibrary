using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBookLibrary.Models
{
    public enum Format
    {
        eBook, Hardback, Paperback
    }

    public class Book
    {

        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public string Title { get; set; }
        public Format Format { get; set; }

        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}