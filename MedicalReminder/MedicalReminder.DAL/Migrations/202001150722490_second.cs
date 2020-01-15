namespace MedicalReminder.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prescriptions", "User_Id", "dbo.Users");
            DropIndex("dbo.Prescriptions", new[] { "User_Id" });
            CreateTable(
                "dbo.UserWithPrescriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Prescriptions", "UserWithPrescription_Id", c => c.Guid());
            CreateIndex("dbo.Prescriptions", "UserWithPrescription_Id");
            AddForeignKey("dbo.Prescriptions", "UserWithPrescription_Id", "dbo.UserWithPrescriptions", "Id");
            DropColumn("dbo.Prescriptions", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prescriptions", "User_Id", c => c.Guid());
            DropForeignKey("dbo.UserWithPrescriptions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Prescriptions", "UserWithPrescription_Id", "dbo.UserWithPrescriptions");
            DropIndex("dbo.UserWithPrescriptions", new[] { "User_Id" });
            DropIndex("dbo.Prescriptions", new[] { "UserWithPrescription_Id" });
            DropColumn("dbo.Prescriptions", "UserWithPrescription_Id");
            DropTable("dbo.UserWithPrescriptions");
            CreateIndex("dbo.Prescriptions", "User_Id");
            AddForeignKey("dbo.Prescriptions", "User_Id", "dbo.Users", "Id");
        }
    }
}
