namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "State");
        }
    }
}
