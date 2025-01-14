namespace Otomasyon.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoAdi = c.String(maxLength: 50, unicode: false),
                        Aciklama = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoId = c.Int(nullable: false),
                        UrunKodu = c.String(maxLength: 20, unicode: false),
                        UrunAdi = c.String(),
                        BirimFiyati1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BirimFiyati2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depo", t => t.DepoId, cascadeDelete: true)
                .Index(t => t.DepoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "DepoId", "dbo.Depo");
            DropIndex("dbo.Urun", new[] { "DepoId" });
            DropTable("dbo.Urun");
            DropTable("dbo.Depo");
        }
    }
}
