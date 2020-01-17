using System;
using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class Prescription:IDEntity
    {
        public DateTime DateOfPresproption { get; set; }

        public virtual Doctor Doctor { get; set; }

        public Guid DrugId { get; set; }
        public Drug Drug { get; set; }

        public ICollection<UserWithPrescription> UserWithPrescription { get; set; }
    }
}