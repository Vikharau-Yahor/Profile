//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Profile.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGroupEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "TeamPurpose", c => c.String());
            AddColumn("dbo.Groups", "TeamworkDesciption", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "TeamworkDesciption");
            DropColumn("dbo.Groups", "TeamPurpose");
        }
    }
}
