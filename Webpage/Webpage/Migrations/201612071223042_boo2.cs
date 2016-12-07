namespace Webpage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class boo2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        ResourceID = c.Int(nullable: false, identity: true),
                        Culture = c.String(),
                        Name = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.ResourceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resources");
        }
    }
}
