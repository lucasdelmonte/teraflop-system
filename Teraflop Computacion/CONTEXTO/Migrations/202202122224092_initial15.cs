namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buys",
                c => new
                    {
                        Cod_Buy = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Total = c.Double(nullable: false),
                        oProvider_Cod_Provider = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_Buy)
                .ForeignKey("dbo.Providers", t => t.oProvider_Cod_Provider)
                .Index(t => t.oProvider_Cod_Provider);
            
            AddColumn("dbo.DetailBuys", "Buy_Cod_Buy", c => c.Int());
            CreateIndex("dbo.DetailBuys", "Buy_Cod_Buy");
            AddForeignKey("dbo.DetailBuys", "Buy_Cod_Buy", "dbo.Buys", "Cod_Buy");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buys", "oProvider_Cod_Provider", "dbo.Providers");
            DropForeignKey("dbo.DetailBuys", "Buy_Cod_Buy", "dbo.Buys");
            DropIndex("dbo.DetailBuys", new[] { "Buy_Cod_Buy" });
            DropIndex("dbo.Buys", new[] { "oProvider_Cod_Provider" });
            DropColumn("dbo.DetailBuys", "Buy_Cod_Buy");
            DropTable("dbo.Buys");
        }
    }
}
