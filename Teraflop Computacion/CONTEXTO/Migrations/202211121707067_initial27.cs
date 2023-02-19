namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial27 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailBuys", "Received", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailBuys", "Received");
        }
    }
}
