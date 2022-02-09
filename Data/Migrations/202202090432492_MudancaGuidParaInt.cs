namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancaGuidParaInt : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.User");
            AddColumn("dbo.User", "DateRegister", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddPrimaryKey("dbo.User", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.User");
            AlterColumn("dbo.User", "Email", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.User", "Name", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.User", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.User", "DateRegister");
            AddPrimaryKey("dbo.User", "Id");
        }
    }
}
