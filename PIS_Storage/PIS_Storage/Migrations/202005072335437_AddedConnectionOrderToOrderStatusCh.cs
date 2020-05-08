namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedConnectionOrderToOrderStatusCh : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.OrderStatusChanges", "OrderId");
            AddForeignKey("dbo.OrderStatusChanges", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderStatusChanges", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderStatusChanges", new[] { "OrderId" });
        }
    }
}
