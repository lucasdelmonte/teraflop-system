namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial17 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Buys", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buys", "Total", c => c.Double(nullable: false));
        }
    }
}
