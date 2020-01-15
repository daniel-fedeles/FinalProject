using MedicalReminder.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalReminder.DAL
{
    public class MedicalReminderDbContext:DbContext
    {
        public MedicalReminderDbContext():base("MedicalApp")
        {
            
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserWithPrescription> UserWithPrescriptions { get; set; }


    }
}
