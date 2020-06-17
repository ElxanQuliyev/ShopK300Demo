namespace ShopAppK300.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProPicture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductToPictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        PictureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pictures", t => t.PictureID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.PictureID);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Url = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductToPictures", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductToPictures", "PictureID", "dbo.Pictures");
            DropIndex("dbo.ProductToPictures", new[] { "PictureID" });
            DropIndex("dbo.ProductToPictures", new[] { "ProductID" });
            DropTable("dbo.Pictures");
            DropTable("dbo.ProductToPictures");
        }
    }
}
