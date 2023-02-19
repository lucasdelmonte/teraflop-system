namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sales", "Total_Cod_DetailSale", "dbo.DetailSales");
            DropIndex("dbo.Sales", new[] { "Total_Cod_DetailSale" });
            AddColumn("dbo.Sales", "Total", c => c.Double(nullable: false));
            DropColumn("dbo.Sales", "Total_Cod_DetailSale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "Total_Cod_DetailSale", c => c.Int());
            DropColumn("dbo.Sales", "Total");
            CreateIndex("dbo.Sales", "Total_Cod_DetailSale");
            AddForeignKey("dbo.Sales", "Total_Cod_DetailSale", "dbo.DetailSales", "Cod_DetailSale");
        }
    }
}
