namespace FrameworkStokTakipProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductStocks",
                c => new
                    {
                        ProductStockID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductNumber = c.Int(nullable: false),
                        ProductDate = c.DateTime(nullable: false),
                        Recorder = c.String(),
                        ProductTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductStockID)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeID, cascadeDelete: true)
                .Index(t => t.ProductTypeID);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeID = c.Int(nullable: false, identity: true),
                        ProductTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStocks", "ProductTypeID", "dbo.ProductTypes");
            DropIndex("dbo.ProductStocks", new[] { "ProductTypeID" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.ProductStocks");
        }
    }
}
