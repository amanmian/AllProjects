namespace August_09_01_Full_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtab1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetailsWebTables",
                c => new
                    {
                        Stud_addr_id = c.Int(nullable: false, identity: true),
                        Stud_area = c.String(),
                        Stud_street = c.String(),
                        Stud_city = c.String(),
                        Stud_zipcode = c.String(),
                    })
                .PrimaryKey(t => t.Stud_addr_id);
            
            CreateTable(
                "dbo.StudentWebTables",
                c => new
                    {
                        Stud_id = c.Int(nullable: false, identity: true),
                        Stud_fname = c.String(),
                        Stud_lname = c.String(),
                        Stud_std = c.Int(nullable: false),
                        Stud_group = c.String(),
                        Stud_cousre = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Stud_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentWebTables");
            DropTable("dbo.StudentDetailsWebTables");
        }
    }
}
