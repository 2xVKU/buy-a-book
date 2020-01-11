namespace LetsGetThisDone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SDetailsMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Img", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Img");
        }
    }
}
