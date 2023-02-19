namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial16 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DetailBuys", "Price");
            DropColumn("dbo.DetailBuys", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetailBuys", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.DetailBuys", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
