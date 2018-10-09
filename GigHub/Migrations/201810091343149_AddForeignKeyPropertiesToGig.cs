namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToGig : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Gigs", name: "Artist_Id", newName: "ArtistId");
            RenameIndex(table: "dbo.Gigs", name: "IX_Artist_Id", newName: "IX_ArtistId");
            AddColumn("dbo.Gigs", "GenerId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "GenerId");
            RenameIndex(table: "dbo.Gigs", name: "IX_ArtistId", newName: "IX_Artist_Id");
            RenameColumn(table: "dbo.Gigs", name: "ArtistId", newName: "Artist_Id");
        }
    }
}
