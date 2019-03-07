namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuspend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "StartSuspend", c => c.DateTime());
            AddColumn("dbo.TrashCanSchedules", "EndSuspend", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCanSchedules", "EndSuspend");
            DropColumn("dbo.TrashCanSchedules", "StartSuspend");
        }
    }
}
