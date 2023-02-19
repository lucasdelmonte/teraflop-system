namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial29 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerAuds",
                c => new
                    {
                        Cod_CustomerAud = c.Int(nullable: false, identity: true),
                        Cod_Customer = c.Int(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Direction = c.String(),
                        Telephone = c.String(),
                        AudUsuario = c.String(),
                        AudFandH = c.String(),
                        AudAction = c.String(),
                    })
                .PrimaryKey(t => t.Cod_CustomerAud);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerAuds");
        }
    }
}
