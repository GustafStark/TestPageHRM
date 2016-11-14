namespace Webpage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOffersID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AboutTheWork = c.String(),
                        Qualifications = c.String(),
                        Email = c.String(),
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
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
            DropTable("dbo.JobOffers");
        }
    }
}
