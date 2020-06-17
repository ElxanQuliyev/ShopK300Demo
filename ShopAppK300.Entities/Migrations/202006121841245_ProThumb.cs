namespace ShopAppK300.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProThumb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ThumbnailID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ThumbnailID");
        }
    }
}
