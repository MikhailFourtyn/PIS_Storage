namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGoodsAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goods", "Amount", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Goods", "Amount");
        }
    }
}
