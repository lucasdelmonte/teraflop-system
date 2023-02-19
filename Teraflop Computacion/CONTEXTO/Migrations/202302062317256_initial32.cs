namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial32 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoginLogoutAuds", "Cod_User", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoginLogoutAuds", "Cod_User");
        }
    }
}
