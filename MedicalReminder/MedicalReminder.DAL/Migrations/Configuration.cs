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

            Drug drug2 = new Drug()
            {
                Id = Guid.Parse(Resource.DrugId2),
                Name = "asasa",
                ExpirationDate = DateTime.Parse("Dec-30-2000"),
                Weight = 2.6
            };
            Prescription prescription = new Prescription()
            {
                Id = Guid.Parse(Resource.PrescriptionId1),
                Doctor = doc,
                Drugs = new List<Drug>() { drug, drug2},
                DateOfPresproption = DateTime.Parse("Dec-30-2020")
            };

            User user = new User()
            {
                Id = Guid.Parse(Resource.UserId1),
                FirstName = "aaa",
                LastName = "bbb",
                Email = "zzz@yyy.ccc",
                UserName = "blabla",
                DateOfBirth = DateTime.Parse("Jan-22-1983"),
                Prescriptions = new List<Prescription>() { prescription}
            };

            context.Doctors.AddOrUpdate(id => id.Id, doc);
            context.Drugs.AddOrUpdate(id => id.Id, drug);
            context.Prescriptions.AddOrUpdate(id => id.Id, prescription);
            context.Users.AddOrUpdate(id => id.Id, user);

        }
    }
}
