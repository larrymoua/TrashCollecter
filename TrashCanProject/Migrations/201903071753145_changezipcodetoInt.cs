namespace TrashCanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changezipcodetoInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "ZipCode", c => c.String());
            AlterColumn("dbo.Customers", "ZipCode", c => c.String());
        }
    }
}
