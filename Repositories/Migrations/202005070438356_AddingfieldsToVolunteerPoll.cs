namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingfieldsToVolunteerPoll : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VolunteerPolls", "InstagramAccount", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VolunteerPolls", "InstagramAccount");
        }
    }
}
