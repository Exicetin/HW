namespace HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddroleMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Role", c => c.String());
            AddColumn("dbo.Users", "Surname", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.Users", "Middle_name", c => c.String());
            AddColumn("dbo.Users", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Position");
            DropColumn("dbo.Users", "Middle_name");
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "Surname");
            DropColumn("dbo.Users", "Role");
        }
    }
}
