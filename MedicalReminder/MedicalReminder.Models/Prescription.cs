using System;
using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class Prescription : IDEntity
    {
        public Prescription()
        {
            Drugs = new List<Drug>();
        }
        public DateTime DateOfPresproption { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Drug> Drugs { get; set; }
    }
}