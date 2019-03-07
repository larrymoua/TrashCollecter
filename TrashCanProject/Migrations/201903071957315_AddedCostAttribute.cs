namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCostAttribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCanSchedules", "Cost", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCanSchedules", "Cost");
        }
    }
}
