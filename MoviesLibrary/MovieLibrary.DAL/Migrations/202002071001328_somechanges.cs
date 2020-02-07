namespace MovieLibrary.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somechanges : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "User_Id", newName: "UserApp_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_User_Id", newName: "IX_UserApp_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_UserApp_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Movies", name: "UserApp_Id", newName: "User_Id");
        }
    }
}
