namespace RadioactiveAgentsAccounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Institutions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DistrictID = c.Int(nullable: false),
                        ProvinceID = c.Int(nullable: false),
                        RegionID = c.Int(nullable: false),
                        LastInventarisationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Districts", t => t.DistrictID, cascadeDelete: true)
                .ForeignKey("dbo.Provinces", t => t.ProvinceID, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionID, cascadeDelete: true)
                .Index(t => t.DistrictID)
                .Index(t => t.ProvinceID)
                .Index(t => t.RegionID);
            
            CreateTable(
                "dbo.InstIrsAmounts",
                c => new
                    {
                        InstitutionID = c.Int(nullable: false),
                        IrsID = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InstitutionID, t.IrsID })
                .ForeignKey("dbo.Institutions", t => t.InstitutionID, cascadeDelete: true)
                .ForeignKey("dbo.IRS", t => t.IrsID, cascadeDelete: true)
                .Index(t => t.InstitutionID)
                .Index(t => t.IrsID);
            
            CreateTable(
                "dbo.IRS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InstRawAmounts",
                c => new
                    {
                        InstitutionID = c.Int(nullable: false),
                        RawID = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InstitutionID, t.RawID })
                .ForeignKey("dbo.Institutions", t => t.InstitutionID, cascadeDelete: true)
                .ForeignKey("dbo.RAWs", t => t.RawID, cascadeDelete: true)
                .Index(t => t.InstitutionID)
                .Index(t => t.RawID);
            
            CreateTable(
                "dbo.RAWs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Institutions", "RegionID", "dbo.Regions");
            DropForeignKey("dbo.Institutions", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.InstRawAmounts", "RawID", "dbo.RAWs");
            DropForeignKey("dbo.InstRawAmounts", "InstitutionID", "dbo.Institutions");
            DropForeignKey("dbo.InstIrsAmounts", "IrsID", "dbo.IRS");
            DropForeignKey("dbo.InstIrsAmounts", "InstitutionID", "dbo.Institutions");
            DropForeignKey("dbo.Institutions", "DistrictID", "dbo.Districts");
            DropIndex("dbo.InstRawAmounts", new[] { "RawID" });
            DropIndex("dbo.InstRawAmounts", new[] { "InstitutionID" });
            DropIndex("dbo.InstIrsAmounts", new[] { "IrsID" });
            DropIndex("dbo.InstIrsAmounts", new[] { "InstitutionID" });
            DropIndex("dbo.Institutions", new[] { "RegionID" });
            DropIndex("dbo.Institutions", new[] { "ProvinceID" });
            DropIndex("dbo.Institutions", new[] { "DistrictID" });
            DropTable("dbo.Regions");
            DropTable("dbo.Provinces");
            DropTable("dbo.RAWs");
            DropTable("dbo.InstRawAmounts");
            DropTable("dbo.IRS");
            DropTable("dbo.InstIrsAmounts");
            DropTable("dbo.Institutions");
            DropTable("dbo.Districts");
        }
    }
}
