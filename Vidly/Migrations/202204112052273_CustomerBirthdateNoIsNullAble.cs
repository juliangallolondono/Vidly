namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBirthdateNoIsNullAble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
