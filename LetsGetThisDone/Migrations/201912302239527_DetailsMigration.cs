namespace LetsGetThisDone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DetailsMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Img");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Img", c => c.String(nullable: false));
        }
    }
}
