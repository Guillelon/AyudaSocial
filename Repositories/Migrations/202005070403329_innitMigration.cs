namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class innitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HelpPolls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        WhosHelping = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        ChatNumber = c.String(),
                        HelpNeededImportance = c.String(),
                        ResidenceType = c.String(),
                        HowManyEldersInHouseHold = c.String(),
                        HowManyAdultsInHouseHold = c.String(),
                        AgeRange = c.String(),
                        HouseHoldHasPublicOfficer = c.String(),
                        HouseHoldHasIncome = c.String(),
                        Profession = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VolunteerPolls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.String(),
                        PhoneNumber = c.String(),
                        ChatNumber = c.String(),
                        HaveCar = c.String(),
                        CanSupportWithMinutes = c.String(),
                        AreaAddress = c.String(),
                        TimeToHelp = c.String(),
                        Profession = c.String(),
                        Hobbies = c.String(),
                        WayToHelp = c.String(),
                        AbleToShareInSN = c.String(),
                        AbleToCollectMoney = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VolunteerPolls");
            DropTable("dbo.HelpPolls");
        }
    }
}
