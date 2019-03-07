namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PickupDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "PickUpDay", c => c.String());
            DropColumn("dbo.TrashCanSchedules", "PickUpDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrashCanSchedules", "PickUpDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TrashCanSchedules", "PickUpDay");
        }
    }
}
