//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Profile.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFileEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artefacts", "TraineeProfileId", "dbo.TraineeProfiles");
            DropIndex("dbo.Artefacts", new[] { "TraineeProfileId" });
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Data = c.Binary(),
                        TraineeProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TraineeProfiles", t => t.TraineeProfileId)
                .Index(t => t.TraineeProfileId);
            
            DropTable("dbo.Artefacts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Artefacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                        TraineeProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Files", "TraineeProfileId", "dbo.TraineeProfiles");
            DropIndex("dbo.Files", new[] { "TraineeProfileId" });
            DropTable("dbo.Files");
            CreateIndex("dbo.Artefacts", "TraineeProfileId");
            AddForeignKey("dbo.Artefacts", "TraineeProfileId", "dbo.TraineeProfiles", "Id");
        }
    }
}
