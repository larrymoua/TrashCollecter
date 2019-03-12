namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrashCanSchedules", "ExtraPickupDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCanSchedules", "ExtraPickupDate", c => c.DateTime(nullable: false));
        }
    }
}
