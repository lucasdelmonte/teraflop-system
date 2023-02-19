namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial25 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailDeliveries", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailDeliveries", "Total");
        }
    }
}
