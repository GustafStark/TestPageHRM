namespace Webpage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ImagePath");
        }
    }
}
