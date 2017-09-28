namespace Project4thAug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        MariStatus = c.Boolean(nullable: false),
                        State = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.States");
            DropTable("dbo.Information");
            DropTable("dbo.Cities");
        }
    }
}
