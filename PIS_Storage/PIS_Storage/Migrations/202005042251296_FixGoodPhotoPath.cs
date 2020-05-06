namespace PIS_Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixGoodPhotoPath : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Goods", "PhotoPath", c => c.String(maxLength: 400, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Goods", "PhotoPath", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
