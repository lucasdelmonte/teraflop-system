namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Cod_Product = c.Int(nullable: false, identity: true),
                        Barcode = c.String(),
                        Name = c.String(),
                        Stock = c.Int(nullable: false),
                        Discount = c.Single(nullable: false),
                        Purchase_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        oCategory_Cod_Category = c.Int(),
                        oMark_Cod_Mark = c.Int(),
                        oModel_Cod_Model = c.Int(),
                    })
                .PrimaryKey(t => t.Cod_Product)
                .ForeignKey("dbo.Categories", t => t.oCategory_Cod_Category)
                .ForeignKey("dbo.Marks", t => t.oMark_Cod_Mark)
                .ForeignKey("dbo.Models", t => t.oModel_Cod_Model)
                .Index(t => t.oCategory_Cod_Category)
                .Index(t => t.oMark_Cod_Mark)
                .Index(t => t.oModel_Cod_Model);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "oModel_Cod_Model", "dbo.Models");
            DropForeignKey("dbo.Products", "oMark_Cod_Mark", "dbo.Marks");
            DropForeignKey("dbo.Products", "oCategory_Cod_Category", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "oModel_Cod_Model" });
            DropIndex("dbo.Products", new[] { "oMark_Cod_Mark" });
            DropIndex("dbo.Products", new[] { "oCategory_Cod_Category" });
            DropTable("dbo.Products");
        }
    }
}
