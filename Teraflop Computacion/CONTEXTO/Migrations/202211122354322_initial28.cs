namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial28 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetailDeliveryDeliveries", "DetailDelivery_Cod_DetailDelivery", "dbo.DetailDeliveries");
            DropForeignKey("dbo.DetailDeliveryDeliveries", "Delivery_Cod_Delivery", "dbo.Deliveries");
            DropIndex("dbo.DetailDeliveryDeliveries", new[] { "DetailDelivery_Cod_DetailDelivery" });
            DropIndex("dbo.DetailDeliveryDeliveries", new[] { "Delivery_Cod_Delivery" });
            AddColumn("dbo.DetailDeliveries", "Delivery_Cod_Delivery", c => c.Int());
            CreateIndex("dbo.DetailDeliveries", "Delivery_Cod_Delivery");
            AddForeignKey("dbo.DetailDeliveries", "Delivery_Cod_Delivery", "dbo.Deliveries", "Cod_Delivery");
            DropTable("dbo.DetailDeliveryDeliveries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DetailDeliveryDeliveries",
                c => new
                    {
                        DetailDelivery_Cod_DetailDelivery = c.Int(nullable: false),
                        Delivery_Cod_Delivery = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DetailDelivery_Cod_DetailDelivery, t.Delivery_Cod_Delivery });
            
            DropForeignKey("dbo.DetailDeliveries", "Delivery_Cod_Delivery", "dbo.Deliveries");
            DropIndex("dbo.DetailDeliveries", new[] { "Delivery_Cod_Delivery" });
            DropColumn("dbo.DetailDeliveries", "Delivery_Cod_Delivery");
            CreateIndex("dbo.DetailDeliveryDeliveries", "Delivery_Cod_Delivery");
            CreateIndex("dbo.DetailDeliveryDeliveries", "DetailDelivery_Cod_DetailDelivery");
            AddForeignKey("dbo.DetailDeliveryDeliveries", "Delivery_Cod_Delivery", "dbo.Deliveries", "Cod_Delivery", cascadeDelete: true);
            AddForeignKey("dbo.DetailDeliveryDeliveries", "DetailDelivery_Cod_DetailDelivery", "dbo.DetailDeliveries", "Cod_DetailDelivery", cascadeDelete: true);
        }
    }
}
