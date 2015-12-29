namespace PomStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterData01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "SalesPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "OrginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Product", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Product", "OrginalPrice");
            DropColumn("dbo.Product", "SalesPrice");
        }
    }
}
