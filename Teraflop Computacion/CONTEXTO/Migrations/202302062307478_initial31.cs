namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial31 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginLogoutAuds",
                c => new
                    {
                        Cod_LoginLogoutAud = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Role = c.String(),
                        AudUsuario = c.String(),
                        AudFandH = c.String(),
                        AudAction = c.String(),
                    })
                .PrimaryKey(t => t.Cod_LoginLogoutAud);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginLogoutAuds");
        }
    }
}
