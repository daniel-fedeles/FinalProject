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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User table
            modelBuilder.Entity<User>()
                .HasKey<Guid>(x => x.Id).Property(p => p.Id).IsRequired();
            modelBuilder.Entity<User>()
                .Property(p => p.Email).IsRequired().HasMaxLength(250);
            modelBuilder.Entity<User>()
                .Property(p => p.UserName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(p => p.FirstName).IsOptional().HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(p => p.LastName).IsOptional().HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(p => p.DateOfBirth).IsRequired().HasColumnType("datetime2").HasPrecision(0);


            //Doctor table
            modelBuilder.Entity<Doctor>()
                .HasKey<Guid>(x => x.Id).Property(p => p.Id).IsRequired();
            modelBuilder.Entity<Doctor>()
                .Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Doctor>()
                .Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Doctor>()
                .Property(p => p.Specialization).IsOptional();
            modelBuilder.Entity<Doctor>()
                .Property(p => p.Hospital).IsOptional();



            //Drug table
            modelBuilder.Entity<Drug>()
                .HasKey<Guid>(x => x.Id).Property(p => p.Id).IsRequired();
            modelBuilder.Entity<Drug>()
                .Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Drug>()
                .Property(p => p.ExpirationDate).IsRequired().HasColumnType("datetime2").HasPrecision(0);
            modelBuilder.Entity<Drug>()
                .Property(p => p.ManufactureDate).IsOptional().HasColumnType("datetime2").HasPrecision(0);
            modelBuilder.Entity<Drug>()
                .Property(p => p.NrOfDaysFromOpening).IsOptional().HasColumnType("datetime2").HasPrecision(0);


            //Prescription table
            modelBuilder.Entity<Prescription>()
                .HasKey<Guid>(x => x.Id)
                .Property(p => p.Id)
                .IsRequired();

            modelBuilder.Entity<Prescription>()
                .Property(p => p.DateOfPresproption)
                .IsRequired()
                .HasColumnType("datetime2")
                .HasPrecision(0);


            //UserWithPrescription table
            modelBuilder.Entity<UserWithPrescription>()
                .HasKey<Guid>(x => x.Id)
                .Property(p => p.Id)
                .IsRequired();


            //Relationships
            //One to one
            modelBuilder.Entity<Prescription>()
                .HasOptional<Doctor>(x => x.Doctor)
                .WithRequired(z => z.Prescription);

            modelBuilder.Entity<UserWithPrescription>()
                .HasOptional<User>(x => x.User)
                .WithRequired(z => z.UserWithPrescription);

            //One to many
            //One prescription with many drugs
            modelBuilder.Entity<Prescription>()
                .HasRequired<Drug>(x => x.Drug)
                .WithMany(z => z.Prescription)
                .HasForeignKey<Guid>(fk => fk.DrugId);

            //One User with many prescription
            modelBuilder.Entity<UserWithPrescription>()
                .HasRequired<Prescription>(x => x.Prescription)
                .WithMany(z => z.UserWithPrescription)
                .HasForeignKey<Guid>(fk => fk.PrescriptionId);


        }
    }
}
