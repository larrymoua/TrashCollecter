namespace TrashCollecterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CustomerId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CustomerId");
        }
    }
}
