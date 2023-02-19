namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Cod_Provider = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Direction = c.String(),
                        Telephone = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Cod_Provider);
            
            AddColumn("dbo.Categories", "Provider_Cod_Provider", c => c.Int());
            CreateIndex("dbo.Categories", "Provider_Cod_Provider");
            AddForeignKey("dbo.Categories", "Provider_Cod_Provider", "dbo.Providers", "Cod_Provider");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Provider_Cod_Provider", "dbo.Providers");
            DropIndex("dbo.Categories", new[] { "Provider_Cod_Provider" });
            DropColumn("dbo.Categories", "Provider_Cod_Provider");
            DropTable("dbo.Providers");
        }
    }
}
