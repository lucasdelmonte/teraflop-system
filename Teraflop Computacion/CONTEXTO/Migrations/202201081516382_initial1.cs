namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Cod_User = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Name = c.String(),
                        Apellido = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Cod_User);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
