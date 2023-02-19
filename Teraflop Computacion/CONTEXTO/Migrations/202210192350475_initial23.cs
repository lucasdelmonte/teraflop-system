namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deliveries", "Buy_Cod_Buy", c => c.Int());
            CreateIndex("dbo.Deliveries", "Buy_Cod_Buy");
            AddForeignKey("dbo.Deliveries", "Buy_Cod_Buy", "dbo.Buys", "Cod_Buy");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "Buy_Cod_Buy", "dbo.Buys");
            DropIndex("dbo.Deliveries", new[] { "Buy_Cod_Buy" });
            DropColumn("dbo.Deliveries", "Buy_Cod_Buy");
        }
    }
}
