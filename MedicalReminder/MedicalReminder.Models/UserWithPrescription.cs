using System;
using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class UserWithPrescription:IDEntity
    {
        public virtual User User { get; set; }
        public Guid PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
    }
}