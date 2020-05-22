namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingSomeValidatins : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HelpPolls", "AgeRange", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HelpPolls", "AgeRange", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
