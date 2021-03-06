//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Profile.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendFileEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FileDatas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Data = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Files", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            AddColumn("dbo.Files", "Size", c => c.Int(nullable: false));
            DropColumn("dbo.Files", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Files", "Data", c => c.Binary());
            DropForeignKey("dbo.FileDatas", "Id", "dbo.Files");
            DropIndex("dbo.FileDatas", new[] { "Id" });
            DropColumn("dbo.Files", "Size");
            DropTable("dbo.FileDatas");
        }
    }
}
