namespace FluentApiNewappli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(maxLength: 80),
                        Address = c.String(maxLength: 100),
                        MobileNo = c.String(maxLength: 14),
                        PhoneNo = c.String(maxLength: 20),
                        City = c.String(maxLength: 40),
                        District = c.String(maxLength: 40),
                        State = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderedItem = c.String(maxLength: 50),
                        OrderedQuantity = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
