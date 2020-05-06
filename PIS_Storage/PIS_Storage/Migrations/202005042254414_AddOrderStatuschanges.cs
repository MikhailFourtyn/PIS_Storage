namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderStatuschanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderStatusChanges",
                c => new
                    {
                        OrderStatusChangeId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        OrderStatus = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.OrderStatusChangeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderStatusChanges");
        }
    }
}
