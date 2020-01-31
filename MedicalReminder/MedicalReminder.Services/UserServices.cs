using MedicalReminder.DAL.Interfaces;
using MedicalReminder.Models;
using System;
using System.Linq;

namespace MedicalReminder.Services
{
    public class UserServices
    {
        private readonly IUserRepository userRepo;
        private readonly IPrescriptionRepository preRepo;
        private readonly IDrugRepository drugRepo;
        private readonly IDoctorRepository docRepo;

        public UserServices(IUserRepository userRepo,
            IPrescriptionRepository preRepo,
            IDrugRepository drugRepo,
            IDoctorRepository docRepo)
        {
            this.drugRepo = drugRepo;
            this.docRepo = docRepo;
            this.preRepo = preRepo;
            this.userRepo = userRepo;
        }

        public User GetCurrentUserWithPrescriptions(Guid id)
        {
            var newUser = new User();
            var user = userRepo.GetById(id);
            var pres = preRepo.GetAll();
            var doc = docRepo.GetAll();
            var drug = drugRepo.GetAll();

            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.UserName = user.UserName;
            newUser.Email = user.Email;
            newUser.Id = user.Id;
            var prescription = pres.FirstOrDefault(a => a.UserId == newUser.Id);
            prescription.Doctor = doc.FirstOrDefault(d => d.Id == prescription.DoctorId);
            var drugs = drug.Where(drug1 => drug1.PrescriptionId == prescription.Id);


            prescription.Drugs = drugs.ToList();
            newUser.Prescriptions.Add(prescription);


            return newUser;
        }

    }
}