namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class costIsdouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrashCanSchedules", "Cost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCanSchedules", "Cost", c => c.String());
        }
    }
}
