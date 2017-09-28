namespace FluentApiNewappli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtableForce : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.OrderCourseNew",
                c => new
                    {
                        ProductRefId = c.Int(nullable: false),
                        OrderRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductRefId, t.OrderRefId })
                .ForeignKey("dbo.Orders", t => t.ProductRefId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.OrderRefId, cascadeDelete: true)
                .Index(t => t.ProductRefId)
                .Index(t => t.OrderRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderCourseNew", "OrderRefId", "dbo.Products");
            DropForeignKey("dbo.OrderCourseNew", "ProductRefId", "dbo.Orders");
            DropIndex("dbo.OrderCourseNew", new[] { "OrderRefId" });
            DropIndex("dbo.OrderCourseNew", new[] { "ProductRefId" });
            DropTable("dbo.OrderCourseNew");
            DropTable("dbo.Products");
        }
    }
}
