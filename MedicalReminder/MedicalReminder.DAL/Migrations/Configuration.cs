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
            User user = new User()
            {
                Id = Guid.Parse(Resource.UserId1),
                FirstName = "aaa",
                LastName = "bbb",
                Email = "zzz@yyy.ccc",
                UserName = "blabla",
                DateOfBirth = DateTime.Parse("Jan-22-1983")
            };
            Doctor doc = new Doctor()
            {
                Id = Guid.Parse(Resource.DoctorId1),
                FirstName = "zzz",
                LastName = "cccc",
                Hospital = "Arcadia",
                Specialization = "Ceva"
            };
            Drug drug = new Drug()
            {
                Id = Guid.Parse(Resource.DrugId1),
                Name = "Aspenter",
                ExpirationDate = DateTime.Parse("Dec-30-2020"),
                Weight = 23.6
            };
            Prescription prescription = new Prescription()
            {
                Id = Guid.Parse(Resource.PrescriptionId1),
                Doctor = doc,
                Drug = drug,
                DateOfPresproption = DateTime.Parse("Jan/18/2020")
            };
            UserWithPrescription up = new UserWithPrescription()
            {
                Id = Guid.Parse(Resource.UserWithPrescriptionId1),
                User = user,
                Prescription = prescription
            };


            context.Users.AddOrUpdate(x => x.Id, user);
            context.Doctors.AddOrUpdate(x => x.Id, doc);
            context.Drugs.AddOrUpdate(x => x.Id, drug);
            context.Prescriptions.AddOrUpdate(x => x.Id, prescription);
            context.UserWithPrescriptions.AddOrUpdate(x => x.Id, up);

        }
    }
}
