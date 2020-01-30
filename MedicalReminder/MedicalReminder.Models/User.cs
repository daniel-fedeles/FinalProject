using System;
using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class User : IDEntity
    {
        public User()
        {
            Prescriptions = new List<Prescription>();
        }
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }


}
