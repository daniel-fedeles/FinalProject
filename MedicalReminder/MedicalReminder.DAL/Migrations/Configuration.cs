using System.Collections.Generic;
using System.Reflection;
using MedicalReminder.Models;

namespace MedicalReminder.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MedicalReminder.DAL.MedicalReminderDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MedicalReminder.DAL.MedicalReminderDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Doctor doc = new Doctor() { Id = Guid.Parse(Resource.DoctorId1), FirstName = "AAAAAAA", LastName = "bbbbb", Hospital = "Arcadia", Specialization = "Hihi" };
            Drug drug = new Drug(){Id = Guid.Parse(Resource.DrugId1), Name = "Asp", Weight = (decimal) 25.3, ExpirationDate = DateTime.Parse("21.05.2021")};
            List<Drug> drugs = new List<Drug>();
            drugs.Add(drug);
            Prescription prescription = new Prescription() { Id = Guid.Parse(Resource.PrescriptionId1), Doctor = doc, Drugs = drugs };
            List<Prescription> prescriptions = new List<Prescription>();
            prescriptions.Add(prescription);
            User user = new User() { Id = Guid.Parse(Resource.UserId1), Email = "aaa@bbb.ccc", FirstName = "GigiKent", LastName = "HAHA", UserName = "aaa" };
            UserWithPrescription userWithPrescription = new UserWithPrescription(){Id = Guid.Parse(Resource.UserWithPrescriptionId1), User = user, Prescriptions = prescriptions};
            
            
            context.Users.AddOrUpdate(x=>x.Id,user);
            context.Drugs.AddOrUpdate(x=>x.Id, drug);
            context.Prescriptions.AddOrUpdate(x=>x.Id,prescription);
            context.Doctors.AddOrUpdate(x=>x.Id, doc );
            context.UserWithPrescriptions.AddOrUpdate(x=>x.Id, userWithPrescription);


        }
    }
}
