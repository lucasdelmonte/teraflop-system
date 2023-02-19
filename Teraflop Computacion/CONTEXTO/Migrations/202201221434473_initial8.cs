namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailSales",
                c => new
                    {
                        Cod_DetailSale = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        oProduct_Cod_Product = c.Int(),
                        Sale_Cod_Sale = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_DetailSale)
                .ForeignKey("dbo.Products", t => t.oProduct_Cod_Product)
                .ForeignKey("dbo.Sales", t => t.Sale_Cod_Sale)
                .Index(t => t.oProduct_Cod_Product)
                .Index(t => t.Sale_Cod_Sale);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Cod_Sale = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        oCustomer_Cod_Customer = c.Int(),
                        Total_Cod_DetailSale = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_Sale)
                .ForeignKey("dbo.Customers", t => t.oCustomer_Cod_Customer)
                .ForeignKey("dbo.DetailSales", t => t.Total_Cod_DetailSale)
                .Index(t => t.oCustomer_Cod_Customer)
                .Index(t => t.Total_Cod_DetailSale);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "Total_Cod_DetailSale", "dbo.DetailSales");
            DropForeignKey("dbo.Sales", "oCustomer_Cod_Customer", "dbo.Customers");
            DropForeignKey("dbo.DetailSales", "Sale_Cod_Sale", "dbo.Sales");
            DropForeignKey("dbo.DetailSales", "oProduct_Cod_Product", "dbo.Products");
            DropIndex("dbo.Sales", new[] { "Total_Cod_DetailSale" });
            DropIndex("dbo.Sales", new[] { "oCustomer_Cod_Customer" });
            DropIndex("dbo.DetailSales", new[] { "Sale_Cod_Sale" });
            DropIndex("dbo.DetailSales", new[] { "oProduct_Cod_Product" });
            DropTable("dbo.Sales");
            DropTable("dbo.DetailSales");
        }
    }
}
