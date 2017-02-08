namespace KodeFirstSporMerkezi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusBilgis",
                c => new
                    {
                        MusBilgiID = c.Int(nullable: false, identity: true),
                        Musadsoyad = c.String(),
                        Mustel = c.String(),
                        Mussure = c.Int(nullable: false),
                        Musucret = c.Int(nullable: false),
                        Muskayit = c.String(),
                        Musbitis = c.String(),
                    })
                .PrimaryKey(t => t.MusBilgiID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MusBilgis");
        }
    }
}
