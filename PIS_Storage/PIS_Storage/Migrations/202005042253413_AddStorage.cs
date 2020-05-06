namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStorage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        StorageId = c.Int(nullable: false, identity: true),
                        GoodId = c.Int(nullable: false),
                        Amount = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.StorageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Storages");
        }
    }
}
