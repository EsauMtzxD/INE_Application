namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryRegionId = c.Int(nullable: false),
                        StateProvinceId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Street = c.String(nullable: false, unicode: false),
                        NumberHouse = c.String(nullable: false, unicode: false),
                        Colony = c.String(nullable: false, unicode: false),
                        CodePostale = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.CountryRegion", t => t.CountryRegionId, cascadeDelete: true)
                .ForeignKey("dbo.StateProvince", t => t.StateProvinceId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.CountryRegionId)
                .Index(t => t.StateProvinceId);
            
            CreateTable(
                "dbo.Candidate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCandidate = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        AddressId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        PoliticalPartyId = c.Int(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        MotherLastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Nationality = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Birthdate = c.DateTime(nullable: false, precision: 0),
                        Scholarship = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        JobTitle = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Sex = c.String(nullable: false, unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreateBy = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                        ModifyBy = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.PoliticalParty", t => t.PoliticalPartyId, cascadeDelete: true)
                .ForeignKey("dbo.PositionCandidate", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.AddressId)
                .Index(t => t.PoliticalPartyId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.PoliticalParty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameMatch = c.String(nullable: false, unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreateBy = c.String(nullable: false, unicode: false),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                        ModifyBy = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PositionCandidate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamePositition = c.String(nullable: false, unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreateBy = c.String(nullable: false, unicode: false),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                        ModifyBy = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Citizen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCitizen = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        MotherLastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Birthdate = c.String(nullable: false, unicode: false),
                        AddressId = c.Int(nullable: false),
                        KeyElector = c.String(nullable: false, maxLength: 40, unicode: false, storeType: "nvarchar"),
                        CURP = c.String(nullable: false, maxLength: 40, unicode: false, storeType: "nvarchar"),
                        Section = c.String(nullable: false, maxLength: 5, unicode: false, storeType: "nvarchar"),
                        Validity = c.String(nullable: false, unicode: false),
                        Sex = c.String(nullable: false, unicode: false),
                        CIC = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Issue = c.String(nullable: false, unicode: false),
                        RegistrationYear = c.String(nullable: false, unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreateBy = c.String(nullable: false, unicode: false),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                        ModifyBy = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateProvinceId = c.Int(nullable: false),
                        CveEnt = c.String(nullable: false, unicode: false),
                        CveCity = c.String(nullable: false, unicode: false),
                        Description = c.String(nullable: false, unicode: false),
                        CveCab = c.String(nullable: false, unicode: false),
                        NameCab = c.String(unicode: false),
                        PTOT = c.String(nullable: false, unicode: false),
                        PMAS = c.String(nullable: false, unicode: false),
                        PFEM = c.String(nullable: false, unicode: false),
                        VTOT = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StateProvince", t => t.StateProvinceId, cascadeDelete: true)
                .Index(t => t.StateProvinceId);
            
            CreateTable(
                "dbo.StateProvince",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryRegionId = c.Int(nullable: false),
                        CveEnt = c.String(nullable: false, unicode: false),
                        Description = c.String(nullable: false, unicode: false),
                        Abrev = c.String(nullable: false, unicode: false),
                        CveCab = c.String(unicode: false),
                        NameCab = c.String(unicode: false),
                        PTOT = c.String(nullable: false, unicode: false),
                        PMAS = c.String(nullable: false, unicode: false),
                        PFEM = c.String(nullable: false, unicode: false),
                        VTOT = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountryRegion", t => t.CountryRegionId, cascadeDelete: true)
                .Index(t => t.CountryRegionId);
            
            CreateTable(
                "dbo.CountryRegion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        FIPS104 = c.String(nullable: false, unicode: false),
                        ISO2 = c.String(nullable: false, unicode: false),
                        ISO3 = c.String(nullable: false, unicode: false),
                        ISON = c.String(nullable: false, unicode: false),
                        Internet = c.String(nullable: false, unicode: false),
                        Capital = c.String(nullable: false, unicode: false),
                        MapReference = c.String(nullable: false, unicode: false),
                        NationalityPlural = c.String(nullable: false, unicode: false),
                        Currency = c.String(nullable: false, unicode: false),
                        CurrencyCode = c.String(nullable: false, unicode: false),
                        Population = c.Int(nullable: false),
                        Title = c.String(nullable: false, unicode: false),
                        Comment = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeVote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameVote = c.String(nullable: false, unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreateBy = c.String(nullable: false, unicode: false),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                        ModifyBy = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoteDate = c.DateTime(nullable: false, precision: 0),
                        IdTypeVote = c.Int(nullable: false),
                        IdCandidate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreateBy = c.String(nullable: false, unicode: false),
                        ModifiedDate = c.DateTime(nullable: false, precision: 0),
                        ModifyBy = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.IdCandidate, cascadeDelete: true)
                .ForeignKey("dbo.TypeVote", t => t.IdTypeVote, cascadeDelete: true)
                .Index(t => t.IdCandidate)
                .Index(t => t.IdTypeVote);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vote", "IdTypeVote", "dbo.TypeVote");
            DropForeignKey("dbo.Vote", "IdCandidate", "dbo.Candidate");
            DropForeignKey("dbo.Address", "StateProvinceId", "dbo.StateProvince");
            DropForeignKey("dbo.Address", "CountryRegionId", "dbo.CountryRegion");
            DropForeignKey("dbo.Address", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "StateProvinceId", "dbo.StateProvince");
            DropForeignKey("dbo.StateProvince", "CountryRegionId", "dbo.CountryRegion");
            DropForeignKey("dbo.Citizen", "AddressId", "dbo.Address");
            DropForeignKey("dbo.Candidate", "PositionId", "dbo.PositionCandidate");
            DropForeignKey("dbo.Candidate", "PoliticalPartyId", "dbo.PoliticalParty");
            DropForeignKey("dbo.Candidate", "AddressId", "dbo.Address");
            DropIndex("dbo.Vote", new[] { "IdTypeVote" });
            DropIndex("dbo.Vote", new[] { "IdCandidate" });
            DropIndex("dbo.Address", new[] { "StateProvinceId" });
            DropIndex("dbo.Address", new[] { "CountryRegionId" });
            DropIndex("dbo.Address", new[] { "CityId" });
            DropIndex("dbo.City", new[] { "StateProvinceId" });
            DropIndex("dbo.StateProvince", new[] { "CountryRegionId" });
            DropIndex("dbo.Citizen", new[] { "AddressId" });
            DropIndex("dbo.Candidate", new[] { "PositionId" });
            DropIndex("dbo.Candidate", new[] { "PoliticalPartyId" });
            DropIndex("dbo.Candidate", new[] { "AddressId" });
            DropTable("dbo.Vote");
            DropTable("dbo.TypeVote");
            DropTable("dbo.CountryRegion");
            DropTable("dbo.StateProvince");
            DropTable("dbo.City");
            DropTable("dbo.Citizen");
            DropTable("dbo.PositionCandidate");
            DropTable("dbo.PoliticalParty");
            DropTable("dbo.Candidate");
            DropTable("dbo.Address");
        }
    }
}
