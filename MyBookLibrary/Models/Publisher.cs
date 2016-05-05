using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBookLibrary.Models
{
    public class Publisher
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublisherID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}