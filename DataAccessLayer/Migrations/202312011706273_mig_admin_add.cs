namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admin_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminUserName", c => c.String(maxLength: 75));
            AddColumn("dbo.Admins", "AdminPassword", c => c.String(maxLength: 50));
            DropColumn("dbo.Admins", "AminUserName");
            DropColumn("dbo.Admins", "AminPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AminPassword", c => c.String(maxLength: 50));
            AddColumn("dbo.Admins", "AminUserName", c => c.String(maxLength: 75));
            DropColumn("dbo.Admins", "AdminPassword");
            DropColumn("dbo.Admins", "AdminUserName");
        }
    }
}
