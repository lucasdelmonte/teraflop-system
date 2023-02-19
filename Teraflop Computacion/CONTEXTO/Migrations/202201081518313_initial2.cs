namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LastName", c => c.String());
            DropColumn("dbo.Users", "Apellido");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Apellido", c => c.String());
            DropColumn("dbo.Users", "LastName");
        }
    }
}
