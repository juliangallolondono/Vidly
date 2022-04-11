namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movie", "GenreID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movie", "GenreID");
            AddForeignKey("dbo.Movie", "GenreID", "dbo.Genre", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "GenreID", "dbo.Genre");
            DropIndex("dbo.Movie", new[] { "GenreID" });
            DropColumn("dbo.Movie", "GenreID");
            DropTable("dbo.Genre");
        }
    }
}
