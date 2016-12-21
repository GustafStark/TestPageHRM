namespace Webpage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resources", "Page", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resources", "Page");
        }
    }
}
