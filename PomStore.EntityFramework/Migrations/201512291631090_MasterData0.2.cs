namespace PomStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterData02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "Description", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Description", c => c.String(nullable: false, maxLength: 4000));
        }
    }
}
