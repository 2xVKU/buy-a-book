namespace LetsGetThisDone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HadToMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuthorBooks", "Author_MBR", "dbo.Authors");
            DropForeignKey("dbo.AuthorBooks", "Book_ISBN", "dbo.Books");
            DropIndex("dbo.AuthorBooks", new[] { "Author_MBR" });
            DropIndex("dbo.AuthorBooks", new[] { "Book_ISBN" });
            DropTable("dbo.Authors");
            DropTable("dbo.AuthorBooks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AuthorBooks",
                c => new
                    {
                        Author_MBR = c.Int(nullable: false),
                        Book_ISBN = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Author_MBR, t.Book_ISBN });
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        MBR = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.MBR);
            
            CreateIndex("dbo.AuthorBooks", "Book_ISBN");
            CreateIndex("dbo.AuthorBooks", "Author_MBR");
            AddForeignKey("dbo.AuthorBooks", "Book_ISBN", "dbo.Books", "ISBN", cascadeDelete: true);
            AddForeignKey("dbo.AuthorBooks", "Author_MBR", "dbo.Authors", "MBR", cascadeDelete: true);
        }
    }
}
