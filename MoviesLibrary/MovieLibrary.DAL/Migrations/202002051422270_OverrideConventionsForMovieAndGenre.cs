namespace MovieLibrary.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForMovieAndGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Movies", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Movies", new[] { "User_Id" });
            DropPrimaryKey("dbo.Genres");
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Genres", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Movies", "MovieName", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Movies", "User_Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Genres", "Id");
            AddPrimaryKey("dbo.Movies", "Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            CreateIndex("dbo.Movies", "User_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "User_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropPrimaryKey("dbo.Movies");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Movies", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Guid());
            AlterColumn("dbo.Movies", "MovieName", c => c.String());
            AlterColumn("dbo.Movies", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Movies", "User_Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
