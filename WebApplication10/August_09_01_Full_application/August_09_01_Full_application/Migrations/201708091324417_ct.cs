namespace August_09_01_Full_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentWebTables", "studentdetails0002_Stud_addr_id", c => c.Int());
            CreateIndex("dbo.StudentWebTables", "studentdetails0002_Stud_addr_id");
            AddForeignKey("dbo.StudentWebTables", "studentdetails0002_Stud_addr_id", "dbo.StudentDetailsWebTables", "Stud_addr_id");
            DropTable("dbo.StudentViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentViewModels",
                c => new
                    {
                        Stud_id = c.Int(nullable: false, identity: true),
                        Stud_fname = c.String(),
                        Stud_lname = c.String(),
                        Stud_std = c.Int(nullable: false),
                        Stud_group = c.String(),
                        Stud_cousre = c.String(),
                        age = c.Int(nullable: false),
                        Stud_addr_id = c.Int(nullable: false),
                        Stud_area = c.String(),
                        Stud_street = c.String(),
                        Stud_city = c.String(),
                        Stud_zipcode = c.String(),
                    })
                .PrimaryKey(t => t.Stud_id);
            
            DropForeignKey("dbo.StudentWebTables", "studentdetails0002_Stud_addr_id", "dbo.StudentDetailsWebTables");
            DropIndex("dbo.StudentWebTables", new[] { "studentdetails0002_Stud_addr_id" });
            DropColumn("dbo.StudentWebTables", "studentdetails0002_Stud_addr_id");
        }
    }
}
