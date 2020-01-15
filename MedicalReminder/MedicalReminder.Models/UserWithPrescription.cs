using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class UserWithPrescription:IDEntity
    {
        public User User { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }
}