using System.Collections.Generic;
using System.Linq;
using MedicalReminder.Models;

namespace MedicalReminder.DAL
{
    public class UsersRepository
    {
        public List<User> GetAllUsers()
        {
            var dbContext = new MedicalReminderDbContext();
            return dbContext.Users.Select(x => x).ToList();
        }
    }
}