namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDisplayed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCanSchedules", "ZipCode");
        }
    }
}
