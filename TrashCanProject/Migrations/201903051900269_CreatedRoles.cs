namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "TrashCanSchedule_ID", c => c.Int());
            CreateIndex("dbo.TrashCanSchedules", "TrashCanSchedule_ID");
            AddForeignKey("dbo.TrashCanSchedules", "TrashCanSchedule_ID", "dbo.TrashCanSchedules", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrashCanSchedules", "TrashCanSchedule_ID", "dbo.TrashCanSchedules");
            DropIndex("dbo.TrashCanSchedules", new[] { "TrashCanSchedule_ID" });
            DropColumn("dbo.TrashCanSchedules", "TrashCanSchedule_ID");
        }
    }
}
