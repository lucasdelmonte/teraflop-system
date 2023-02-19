namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "DescriptionCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "DescriptionCategory", c => c.String());
        }
    }
}
