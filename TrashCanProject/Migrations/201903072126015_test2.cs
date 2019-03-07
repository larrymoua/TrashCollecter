namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrashCanSchedules", "Cost", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCanSchedules", "Cost", c => c.Double(nullable: false));
        }
    }
}
