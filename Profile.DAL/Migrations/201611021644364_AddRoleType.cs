//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Profile.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Type");
        }
    }
}
