namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedConfirmed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "Confirmed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCanSchedules", "Confirmed");
        }
    }
}
