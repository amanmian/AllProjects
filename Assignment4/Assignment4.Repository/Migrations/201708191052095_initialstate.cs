namespace Assignment4.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialstate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "length", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "length");
        }
    }
}
