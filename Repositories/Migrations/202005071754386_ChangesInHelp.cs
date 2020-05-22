namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInHelp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HelpPolls", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "WhosHelping", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "FirstName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "LastName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "PhoneNumber", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "ChatNumber", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "HelpNeededImportance", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "ResidenceType", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "HowManyEldersInHouseHold", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "HowManyAdultsInHouseHold", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "AgeRange", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "HouseHoldHasPublicOfficer", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "HouseHoldHasIncome", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HelpPolls", "Profession", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "FirstName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "LastName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "Age", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "PhoneNumber", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "ChatNumber", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "HaveCar", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "CanSupportWithMinutes", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "AreaAddress", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "TimeToHelp", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "Profession", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "Hobbies", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "WayToHelp", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "InstagramAccount", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "AbleToShareInSN", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "AbleToCollectMoney", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.VolunteerPolls", "Comments", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VolunteerPolls", "Comments", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "AbleToCollectMoney", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "AbleToShareInSN", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "InstagramAccount", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "WayToHelp", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "Hobbies", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "Profession", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "TimeToHelp", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "AreaAddress", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "CanSupportWithMinutes", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "HaveCar", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "ChatNumber", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "PhoneNumber", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "Age", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "LastName", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "FirstName", c => c.String());
            AlterColumn("dbo.VolunteerPolls", "Email", c => c.String());
            AlterColumn("dbo.HelpPolls", "Profession", c => c.String());
            AlterColumn("dbo.HelpPolls", "HouseHoldHasIncome", c => c.String());
            AlterColumn("dbo.HelpPolls", "HouseHoldHasPublicOfficer", c => c.String());
            AlterColumn("dbo.HelpPolls", "AgeRange", c => c.String());
            AlterColumn("dbo.HelpPolls", "HowManyAdultsInHouseHold", c => c.String());
            AlterColumn("dbo.HelpPolls", "HowManyEldersInHouseHold", c => c.String());
            AlterColumn("dbo.HelpPolls", "ResidenceType", c => c.String());
            AlterColumn("dbo.HelpPolls", "HelpNeededImportance", c => c.String());
            AlterColumn("dbo.HelpPolls", "ChatNumber", c => c.String());
            AlterColumn("dbo.HelpPolls", "PhoneNumber", c => c.String());
            AlterColumn("dbo.HelpPolls", "LastName", c => c.String());
            AlterColumn("dbo.HelpPolls", "FirstName", c => c.String());
            AlterColumn("dbo.HelpPolls", "WhosHelping", c => c.String());
            AlterColumn("dbo.HelpPolls", "Email", c => c.String());
        }
    }
}
