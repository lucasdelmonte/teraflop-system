namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial22 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Cod_Delivery = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Amount = c.Int(nullable: false),
                        oProduct_Cod_Product = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_Delivery)
                .ForeignKey("dbo.Products", t => t.oProduct_Cod_Product)
                .Index(t => t.oProduct_Cod_Product);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "oProduct_Cod_Product", "dbo.Products");
            DropIndex("dbo.Deliveries", new[] { "oProduct_Cod_Product" });
            DropTable("dbo.Deliveries");
        }
    }
}
