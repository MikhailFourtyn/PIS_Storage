namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGoodType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoodTypes",
                c => new
                    {
                        GoodTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.GoodTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GoodTypes");
        }
    }
}
