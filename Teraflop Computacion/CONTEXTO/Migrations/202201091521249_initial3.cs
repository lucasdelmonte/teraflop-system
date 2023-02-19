namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cod_Customer = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Direction = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Cod_Customer);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
