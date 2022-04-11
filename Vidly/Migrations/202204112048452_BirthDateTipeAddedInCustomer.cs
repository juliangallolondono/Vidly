namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthDateTipeAddedInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Birthdate");
        }
    }
}
