namespace MyBookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        PublisherID = c.Int(nullable: false),
                        Title = c.String(),
                        Format = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Author", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Publisher", t => t.PublisherID, cascadeDelete: true)
                .Index(t => t.AuthorID)
                .Index(t => t.PublisherID);
            
            CreateTable(
                "dbo.Publisher",
                c => new
                    {
                        PublisherID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PublisherID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "PublisherID", "dbo.Publisher");
            DropForeignKey("dbo.Book", "AuthorID", "dbo.Author");
            DropIndex("dbo.Book", new[] { "PublisherID" });
            DropIndex("dbo.Book", new[] { "AuthorID" });
            DropTable("dbo.Publisher");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
