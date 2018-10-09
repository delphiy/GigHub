namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToGig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "GenreGenre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "GenreGenre_Id" });
            AlterColumn("dbo.Gigs", "GenreGenre_Id", c => c.Byte());
            CreateIndex("dbo.Gigs", "GenreGenre_Id");
            AddForeignKey("dbo.Gigs", "GenreGenre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "GenreGenre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "GenreGenre_Id" });
            AlterColumn("dbo.Gigs", "GenreGenre_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Gigs", "GenreGenre_Id");
            AddForeignKey("dbo.Gigs", "GenreGenre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
