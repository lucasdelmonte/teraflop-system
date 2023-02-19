namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Cod_Category = c.Int(nullable: false, identity: true),
                        NameCategory = c.String(),
                        DescriptionCategory = c.String(),
                    })
                .PrimaryKey(t => t.Cod_Category);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Cod_Mark = c.Int(nullable: false, identity: true),
                        NameMark = c.String(),
                    })
                .PrimaryKey(t => t.Cod_Mark);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Cod_Model = c.Int(nullable: false, identity: true),
                        NameModel = c.String(),
                    })
                .PrimaryKey(t => t.Cod_Model);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Models");
            DropTable("dbo.Marks");
            DropTable("dbo.Categories");
        }
    }
}
