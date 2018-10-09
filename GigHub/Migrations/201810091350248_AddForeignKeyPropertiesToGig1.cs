namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToGig1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Gigs", name: "Genre_Id", newName: "GenreGenre_Id");
            RenameIndex(table: "dbo.Gigs", name: "IX_Genre_Id", newName: "IX_GenreGenre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Gigs", name: "IX_GenreGenre_Id", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Gigs", name: "GenreGenre_Id", newName: "Genre_Id");
        }
    }
}
