namespace Webpage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Posistion = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        ExperienceID = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.ExperienceID);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        QualificationID = c.Int(nullable: false, identity: true),
                        ExperienceID = c.Int(nullable: false),
                        JobOffersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QualificationID)
                .ForeignKey("dbo.Experiences", t => t.ExperienceID, cascadeDelete: true)
                .ForeignKey("dbo.JobOffers", t => t.JobOffersID, cascadeDelete: true)
                .Index(t => t.ExperienceID)
                .Index(t => t.JobOffersID);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOffersID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AboutTheWork = c.String(),
                        EndDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Visable = c.Boolean(nullable: false),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.JobOffersID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImagePath = c.String(),
                        ShortText = c.String(),
                        LongTest = c.String(),
                        Visable = c.Boolean(nullable: false),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Qualifications", "JobOffersID", "dbo.JobOffers");
            DropForeignKey("dbo.Qualifications", "ExperienceID", "dbo.Experiences");
            DropIndex("dbo.Qualifications", new[] { "JobOffersID" });
            DropIndex("dbo.Qualifications", new[] { "ExperienceID" });
            DropTable("dbo.Posts");
            DropTable("dbo.JobOffers");
            DropTable("dbo.Qualifications");
            DropTable("dbo.Experiences");
            DropTable("dbo.Contacts");
        }
    }
}
