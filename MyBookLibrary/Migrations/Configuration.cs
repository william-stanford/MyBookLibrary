namespace MyBookLibrary.Migrations
{
    using MyBookLibrary.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyBookLibrary.DAL.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyBookLibrary.DAL.LibraryContext context)
        {
            var authors = new List<Author>
            {
                new Author {firstName="Jim",    lastName="Butcher" },
                new Author {firstName="CJ",     lastName="Cherryh" },
                new Author {firstName="Robert", lastName="Crais" },
                new Author {firstName="Janet",  lastName="Evanovich" },
                new Author {firstName="Eric",   lastName="Flint" },
                new Author {firstName="Nathan", lastName="Lowell" },
                new Author {firstName="John",   lastName="Ringo" },
                new Author {firstName="John",   lastName="Sandford" },
                new Author {firstName="David",  lastName="Weber" },
                new Author {firstName="Andy",   lastName="Weir" },
                new Author {firstName="Wil",    lastName="Wheaton" },
                new Author {firstName="Mike",   lastName="Williamson" }
            };
            authors.ForEach(s => context.Authors.AddOrUpdate(p => p.lastName, s));
            context.SaveChanges();

            var publishers = new List<Publisher>
            {
                new Publisher {PublisherID=1, Name="Baen Books" },
                new Publisher {PublisherID=2, Name="Bantam" },
                new Publisher {PublisherID=3, Name="Broadway Books" },
                new Publisher {PublisherID=4, Name="DAW" },
                new Publisher {PublisherID=5, Name="Durandus" },
                new Publisher {PublisherID=6, Name="G.P. Putnam's Sons" },
                new Publisher {PublisherID=7, Name="O'Reilly Media" },
                new Publisher {PublisherID=8, Name="Roc" },
                new Publisher {PublisherID=9, Name="Tor Books" },
            };
            publishers.ForEach(s => context.Publishers.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var books = new List<Book>
            {

                new Book
                {                    
                    AuthorID = authors.Single(s => s.lastName == "Butcher").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Roc").PublisherID,                    
                    Title = "Changes",
                    Format = Format.Hardback
                },

 
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Butcher").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Roc").PublisherID,
                    Title = "Storm Front",
                    Format = Format.Paperback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Butcher").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Roc").PublisherID,
                    Title = "Ghost Story",
                    Format = Format.Hardback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Butcher").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Roc").PublisherID,
                    Title = "Skin Game",
                    Format = Format.Hardback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Cherryh").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "DAW").PublisherID,
                    Title = "Foreigner",
                    Format = Format.Paperback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Cherryh").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "DAW").PublisherID,
                    Title = "Invader",
                    Format = Format.Paperback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Cherryh").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "DAW").PublisherID,
                    Title = "Inheritor",
                    Format = Format.Paperback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Crais").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Chasing Darkness",
                    Format = Format.Hardback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Crais").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Demolition Angel",
                    Format = Format.Paperback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Crais").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Monkey's Raincoat, The",
                    Format = Format.Paperback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Evanovich").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Bantam").PublisherID,
                    Title = "Two for the Dough",
                    Format = Format.eBook
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Flint").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "1632",
                    Format = Format.Paperback
                },    
                            
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Lowell").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Durandus").PublisherID,
                    Title = "Quarter Share",
                    Format = Format.eBook
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Ringo").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "A Hymn Before Battle",
                    Format = Format.Hardback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Ringo").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "Gust Front",
                    Format = Format.Hardback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Ringo").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "There Will Be Dragons",
                    Format = Format.Hardback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Sandford").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Easy Prey",
                    Format = Format.Paperback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Sandford").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Rules of Prey",
                    Format = Format.Paperback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Sandford").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Shadow Prey",
                    Format = Format.Paperback
                },
                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Sandford").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "G.P. Putnam's Sons").PublisherID,
                    Title = "Heat Lightning",
                    Format = Format.Hardback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Weber").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "Flag in Exile",
                    Format = Format.Hardback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Weber").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "In Enemy Hands",
                    Format = Format.Hardback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Weir").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Broadway Books").PublisherID,
                    Title = "Martian, The",
                    Format = Format.Paperback
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Wheaton").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "O'Reilly Media").PublisherID,
                    Title = "Just a Geek",
                    Format = Format.eBook
                },

                new Book
                {
                    
                    AuthorID = authors.Single(s => s.lastName == "Williamson").AuthorID,
                    PublisherID = publishers.Single(c => c.Name == "Baen Books").PublisherID,
                    Title = "Freehold",
                    Format = Format.Paperback
                }

            };

            foreach (Book b in books)
            {
                var bookInDatabase = context.Books.Where(
                    s =>
                        s.Author.AuthorID == b.AuthorID &&
                        s.Publisher.PublisherID == b.PublisherID).SingleOrDefault();

                if (bookInDatabase != null)
                {
                    context.Books.Add(b);
                }
            }

            context.SaveChanges();

        }
    }
}
