namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial26 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DetailDeliveries", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetailDeliveries", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
