namespace WebApplication10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemId = c.Int(nullable: false, identity: true),
                        MemName = c.String(),
                        MemEmail = c.String(),
                        MemAddress = c.String(),
                    })
                .PrimaryKey(t => t.MemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
