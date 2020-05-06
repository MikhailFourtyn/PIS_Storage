namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGood : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        GoodId = c.Int(nullable: false, identity: true),
                        GoodTypeId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 80, unicode: false),
                        Price = c.Short(nullable: false),
                        PhotoPath = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.GoodId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Goods");
        }
    }
}
