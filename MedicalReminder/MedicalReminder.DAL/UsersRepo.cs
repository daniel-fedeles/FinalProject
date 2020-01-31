using MedicalReminder.Models;
using System.Collections.Generic;
using System.Linq;

namespace MedicalReminder.DAL
{
    public class UsersRepo
    {
        public UsersRepo()
        {

        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            var dbContext = new MedicalReminderDbContext();
            var us = new List<User>();
            var pres = new List<Prescription>();
            var d = new List<Doctor>();
            var drugs = new List<Drug>();

            using (dbContext)
            {
                us = dbContext.Users.ToList();
                pres = dbContext.Prescriptions.ToList();
                d = dbContext.Doctors.ToList();
                drugs = dbContext.Drugs.ToList();

            }


            foreach (var user in us)
            {
                users.Add(user);
            }

            return users;
        }


    }
}