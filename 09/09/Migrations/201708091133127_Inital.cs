namespace _09.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetalis1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        RollNo = c.Int(nullable: false),
                        Class = c.String(),
                        studentdetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentDetalis1", t => t.studentdetails_Id)
                .Index(t => t.studentdetails_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student1", "studentdetails_Id", "dbo.StudentDetalis1");
            DropIndex("dbo.Student1", new[] { "studentdetails_Id" });
            DropTable("dbo.Student1");
            DropTable("dbo.StudentDetalis1");
        }
    }
}
