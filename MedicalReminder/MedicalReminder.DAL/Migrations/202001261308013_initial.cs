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
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Specialization = c.String(),
                        Hospital = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prescriptions", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateOfPresproption = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Weight = c.Double(nullable: false),
                        ManufactureDate = c.DateTime(precision: 0, storeType: "datetime2"),
                        ExpirationDate = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        NrOfDaysFromOpening = c.DateTime(precision: 0, storeType: "datetime2"),
                        PrescriptionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prescriptions", t => t.PrescriptionId, cascadeDelete: true)
                .Index(t => t.PrescriptionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 250),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Drugs", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Doctors", "Id", "dbo.Prescriptions");
            DropIndex("dbo.Drugs", new[] { "PrescriptionId" });
            DropIndex("dbo.Prescriptions", new[] { "UserId" });
            DropIndex("dbo.Doctors", new[] { "Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Drugs");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Doctors");
        }
    }
}
