namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntitiesConnections : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Goods", "GoodTypeId");
            CreateIndex("dbo.Orders", "GoodId");
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Goods", "GoodTypeId", "dbo.GoodTypes", "GoodTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "GoodId", "dbo.Goods", "GoodId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "GoodId", "dbo.Goods");
            DropForeignKey("dbo.Goods", "GoodTypeId", "dbo.GoodTypes");
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "GoodId" });
            DropIndex("dbo.Goods", new[] { "GoodTypeId" });
        }
    }
}
