namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Discount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discount", c => c.Single(nullable: false));
        }
    }
}
