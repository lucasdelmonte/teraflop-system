namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial24 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Deliveries", "oProduct_Cod_Product", "dbo.Products");
            DropIndex("dbo.Deliveries", new[] { "oProduct_Cod_Product" });
            CreateTable(
                "dbo.DetailDeliveries",
                c => new
                    {
                        Cod_DetailDelivery = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        oProduct_Cod_Product = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_DetailDelivery)
                .ForeignKey("dbo.Products", t => t.oProduct_Cod_Product)
                .Index(t => t.oProduct_Cod_Product);
            
            CreateTable(
                "dbo.DetailDeliveryDeliveries",
                c => new
                    {
                        DetailDelivery_Cod_DetailDelivery = c.Int(nullable: false),
                        Delivery_Cod_Delivery = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DetailDelivery_Cod_DetailDelivery, t.Delivery_Cod_Delivery })
                .ForeignKey("dbo.DetailDeliveries", t => t.DetailDelivery_Cod_DetailDelivery, cascadeDelete: true)
                .ForeignKey("dbo.Deliveries", t => t.Delivery_Cod_Delivery, cascadeDelete: true)
                .Index(t => t.DetailDelivery_Cod_DetailDelivery)
                .Index(t => t.Delivery_Cod_Delivery);
            
            DropColumn("dbo.Deliveries", "Amount");
            DropColumn("dbo.Deliveries", "oProduct_Cod_Product");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Deliveries", "oProduct_Cod_Product", c => c.Int());
            AddColumn("dbo.Deliveries", "Amount", c => c.Int(nullable: false));
            DropForeignKey("dbo.DetailDeliveries", "oProduct_Cod_Product", "dbo.Products");
            DropForeignKey("dbo.DetailDeliveryDeliveries", "Delivery_Cod_Delivery", "dbo.Deliveries");
            DropForeignKey("dbo.DetailDeliveryDeliveries", "DetailDelivery_Cod_DetailDelivery", "dbo.DetailDeliveries");
            DropIndex("dbo.DetailDeliveryDeliveries", new[] { "Delivery_Cod_Delivery" });
            DropIndex("dbo.DetailDeliveryDeliveries", new[] { "DetailDelivery_Cod_DetailDelivery" });
            DropIndex("dbo.DetailDeliveries", new[] { "oProduct_Cod_Product" });
            DropTable("dbo.DetailDeliveryDeliveries");
            DropTable("dbo.DetailDeliveries");
            CreateIndex("dbo.Deliveries", "oProduct_Cod_Product");
            AddForeignKey("dbo.Deliveries", "oProduct_Cod_Product", "dbo.Products", "Cod_Product");
        }
    }
}
