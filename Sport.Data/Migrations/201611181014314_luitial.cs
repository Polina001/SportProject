namespace Sport.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class luitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        CoachID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CoachID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Coach_CoachID = c.Int(),
                    })
                .PrimaryKey(t => t.TeamID)
                .ForeignKey("dbo.Coaches", t => t.Coach_CoachID)
                .Index(t => t.Coach_CoachID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Team_TeamID = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerID)
                .ForeignKey("dbo.Teams", t => t.Team_TeamID)
                .Index(t => t.Team_TeamID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Coach_CoachID", "dbo.Coaches");
            DropForeignKey("dbo.Players", "Team_TeamID", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_TeamID" });
            DropIndex("dbo.Teams", new[] { "Coach_CoachID" });
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Coaches");
        }
    }
}
