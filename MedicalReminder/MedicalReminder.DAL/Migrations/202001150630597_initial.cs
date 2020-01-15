namespace MedicalReminder.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Specialization = c.String(),
                        Hospital = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ManufactureDate = c.DateTime(),
                        ExpirationDate = c.DateTime(nullable: false),
                        NrOfDaysFromOpening = c.DateTime(),
                        Prescription_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prescriptions", t => t.Prescription_Id)
                .Index(t => t.Prescription_Id);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Doctor_Id = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Doctor_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Drugs", "Prescription_Id", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.Prescriptions", new[] { "User_Id" });
            DropIndex("dbo.Prescriptions", new[] { "Doctor_Id" });
            DropIndex("dbo.Drugs", new[] { "Prescription_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Drugs");
            DropTable("dbo.Doctors");
        }
    }
}
