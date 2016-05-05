using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyBookLibrary.Models;

namespace MyBookLibrary.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var authors = new List<Author>
            {
                new Author {firstName="Jim", lastName="Butcher" },
                new Author {firstName="CJ", lastName="Cherryh" },
                new Author {firstName="Robert", lastName="Crais" },
                new Author {firstName="Janet", lastName="Evanovich" },
                new Author {firstName="Eric", lastName="Flint" },
                new Author {firstName="Nathan", lastName="Lowell" },
                new Author {firstName="John", lastName="Ringo" },
                new Author {firstName="John", lastName="Sandford" },
                new Author {firstName="David", lastName="Weber" },
                new Author {firstName="Andy", lastName="Weir" },
                new Author {firstName="Wil", lastName="Wheaton" },
                new Author {firstName="Mike", lastName="Williamson" }
            };
            authors.ForEach(s => context.Authors.Add(s));
            context.SaveChanges();

            var publishers = new List<Publisher>
            {
                new Publisher {PublisherID=1, Name="Baen" },
                new Publisher {PublisherID=2, Name="Bantam" },
                new Publisher {PublisherID=3, Name="Broadway Books" },
                new Publisher {PublisherID=4, Name="DAW" },
                new Publisher {PublisherID=5, Name="Durandus" },
                new Publisher {PublisherID=6, Name="G.P. Putnam's Sons" },
                new Publisher {PublisherID=7, Name="O'Reilly Media" },
                new Publisher {PublisherID=8, Name="Roc" },
                new Publisher {PublisherID=9, Name="Tor Books" },
            };
            publishers.ForEach(s => context.Publishers.Add(s));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book {Title="Gust Front", AuthorID=7, PublisherID=1, Format=Format.Hardback },
                new Book {Title="On Basilisk Station", AuthorID=9, PublisherID=1, Format=Format.Paperback },
                new Book {Title="Freehold", AuthorID=12, PublisherID=1, Format=Format.Paperback },
                new Book {Title="Foreigner", AuthorID=2, PublisherID=4, Format=Format.Paperback },
                new Book {Title="1632", AuthorID=5, PublisherID=1, Format=Format.Paperback },
                new Book {Title="Shadow Prey", AuthorID=8, PublisherID=6, Format=Format.Paperback },
                new Book {Title="Changes", AuthorID=1, PublisherID=8, Format=Format.Hardback },
                new Book {Title="Quarter Share", AuthorID=6, PublisherID=5, Format=Format.eBook },
                new Book {Title="The Martian", AuthorID=10, PublisherID=3, Format=Format.Paperback },
                new Book {Title="Just a Geek", AuthorID=11, PublisherID=7, Format=Format.eBook },
                new Book {Title="Off Armageddon Reef", AuthorID=9, PublisherID=9, Format=Format.Hardback },
                new Book {Title="Mortal Prey", AuthorID=8, PublisherID=6, Format=Format.Hardback },
                new Book {Title="Chasing Darkness", AuthorID=3, PublisherID=6, Format=Format.Hardback },
                new Book {Title="Two for the Dough", AuthorID=4, PublisherID=2, Format=Format.eBook },
                new Book {Title="Storm Front", AuthorID=1, PublisherID=8, Format=Format.Paperback },
                new Book {Title="Ghost Story", AuthorID=1, PublisherID=8, Format=Format.Hardback },
                new Book {Title="Skin Game", AuthorID=1, PublisherID=8, Format=Format.Hardback },
                new Book {Title="A Hymn Before Battle", AuthorID=7, PublisherID=1, Format=Format.Hardback },
                new Book {Title="There Will Be Dragons", AuthorID=7, PublisherID=1, Format=Format.Hardback },
                new Book {Title="Invader", AuthorID=2, PublisherID=4, Format=Format.Paperback },
                new Book {Title="Inheritor", AuthorID=2, PublisherID=4, Format=Format.Paperback },
                new Book {Title="Rules of Prey", AuthorID=8, PublisherID=6, Format=Format.Paperback },
                new Book {Title="Heat Lightning", AuthorID=8, PublisherID=6, Format=Format.Hardback }
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();


        }
        
    }
}