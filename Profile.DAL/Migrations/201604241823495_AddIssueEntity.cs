//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Profile.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIssueEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Summary = c.String(),
                        OriginalEstimate = c.Int(nullable: true),
                        TimeSpent = c.Int(nullable: true),
                        IssueType = c.String(),
                        IconUrl = c.String(),
                        Status = c.String(),
                        ColorName = c.String(),
                        TraineeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainees", t => t.TraineeId)
                .Index(t => t.TraineeId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Issues", "TraineeId", "dbo.Trainees");
            DropIndex("dbo.Issues", new[] { "TraineeId" });
            DropTable("dbo.Issues");
        }
    }
}
