namespace Member.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Week_6.MemberApps", "State", c => c.String(nullable: false));
            AlterColumn("Week_6.MemberApps", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Week_6.MemberApps", "City", c => c.String());
            AlterColumn("Week_6.MemberApps", "State", c => c.String());
        }
    }
}
