namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemberShipTypesWithNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipType SET Name = 'Pay as you go' WHERE Id = 1");
            Sql("UPDATE MembershipType SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipType SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipType SET Name = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
