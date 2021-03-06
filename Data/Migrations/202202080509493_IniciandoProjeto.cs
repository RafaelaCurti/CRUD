namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniciandoProjeto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100, unicode: false),
                        Birthday = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Telephone = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
