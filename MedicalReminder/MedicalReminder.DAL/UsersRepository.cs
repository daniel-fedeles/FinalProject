using System.Collections.Generic;
using System.Linq;
using MedicalReminder.Models;

namespace MedicalReminder.DAL
{
    public class UsersRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            IEnumerable<User>users = new List<User>();
            var dbContext = new MedicalReminderDbContext();
            using (dbContext)
            {
                users = dbContext.Users.ToList();
            }

            return users;
        }


    }
}