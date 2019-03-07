namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "pickUpDays", c => c.Int(nullable: false));
            DropColumn("dbo.TrashCanSchedules", "PickUpDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrashCanSchedules", "PickUpDay", c => c.String());
            DropColumn("dbo.TrashCanSchedules", "pickUpDays");
        }
    }
}
