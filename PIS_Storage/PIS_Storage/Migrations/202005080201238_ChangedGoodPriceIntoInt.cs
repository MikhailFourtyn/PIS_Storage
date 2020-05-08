namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedGoodPriceIntoInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Goods", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Goods", "Price", c => c.Short(nullable: false));
        }
    }
}
