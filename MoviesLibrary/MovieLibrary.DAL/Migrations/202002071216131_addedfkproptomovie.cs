namespace MovieLibrary.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfkproptomovie : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
            RenameColumn(table: "dbo.Movies", name: "UserApp_Id", newName: "UserAppId");
            RenameIndex(table: "dbo.Movies", name: "IX_UserApp_Id", newName: "IX_UserAppId");
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_UserAppId", newName: "IX_UserApp_Id");
            RenameColumn(table: "dbo.Movies", name: "UserAppId", newName: "UserApp_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
        }
    }
}
