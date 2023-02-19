namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buys", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buys", "State");
        }
    }
}
