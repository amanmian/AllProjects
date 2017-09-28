namespace WebApplication24.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        description = c.String(maxLength: 255),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author_AuthorId = c.Int(),
                        Profile_firstname = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorId)
                .ForeignKey("dbo.Profiles", t => t.Profile_firstname)
                .Index(t => t.Author_AuthorId)
                .Index(t => t.Profile_firstname);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        firstname = c.String(nullable: false, maxLength: 128),
                        stuid = c.Int(nullable: false),
                        lastname = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.firstname);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        courseId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.courseId, t.Id })
                .ForeignKey("dbo.Courses", t => t.courseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Id, cascadeDelete: true)
                .Index(t => t.courseId)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourse", "Id", "dbo.Students");
            DropForeignKey("dbo.StudentCourse", "courseId", "dbo.Courses");
            DropForeignKey("dbo.Students", "Profile_firstname", "dbo.Profiles");
            DropForeignKey("dbo.Students", "Author_AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropIndex("dbo.StudentCourse", new[] { "Id" });
            DropIndex("dbo.StudentCourse", new[] { "courseId" });
            DropIndex("dbo.Students", new[] { "Profile_firstname" });
            DropIndex("dbo.Students", new[] { "Author_AuthorId" });
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.Profiles");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
