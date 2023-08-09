namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial33 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerAuds", "AudFandH", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoginLogoutAuds", "AudFandH", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LoginLogoutAuds", "AudFandH", c => c.String());
            AlterColumn("dbo.CustomerAuds", "AudFandH", c => c.String());
        }
    }
}
