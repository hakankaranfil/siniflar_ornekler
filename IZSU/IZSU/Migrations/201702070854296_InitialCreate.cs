namespace IZSU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AboneNo = c.Int(nullable: false),
                        AboneAdSoyad = c.String(),
                        AboneTuruId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AboneTurus", t => t.AboneTuruId, cascadeDelete: true)
                .Index(t => t.AboneTuruId);
            
            CreateTable(
                "dbo.AboneTurus",
                c => new
                    {
                        AboneTuruID = c.Int(nullable: false, identity: true),
                        AboneTuruAdi = c.String(),
                    })
                .PrimaryKey(t => t.AboneTuruID);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        FaturaID = c.Int(nullable: false, identity: true),
                        AboneID = c.Int(nullable: false),
                        OncekiSayac = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuncelSayac = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaTarihi = c.DateTime(nullable: false),
                        Tahsilat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abones", "AboneTuruId", "dbo.AboneTurus");
            DropIndex("dbo.Abones", new[] { "AboneTuruId" });
            DropTable("dbo.Faturas");
            DropTable("dbo.AboneTurus");
            DropTable("dbo.Abones");
        }
    }
}
