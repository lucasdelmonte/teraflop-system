namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailBuys",
                c => new
                    {
                        Cod_DetailBuy = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        oProduct_Cod_Product = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_DetailBuy)
                .ForeignKey("dbo.Products", t => t.oProduct_Cod_Product)
                .Index(t => t.oProduct_Cod_Product);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailBuys", "oProduct_Cod_Product", "dbo.Products");
            DropIndex("dbo.DetailBuys", new[] { "oProduct_Cod_Product" });
            DropTable("dbo.DetailBuys");
        }
    }
}
