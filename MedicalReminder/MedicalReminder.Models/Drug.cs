using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedicalReminder.Models
{
    public class Drug:IDEntity
    {
        public string Name { get; set; }

        public double Weight { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime? NrOfDaysFromOpening { get; set; }
        public Prescription Prescription { get; set; }
        public Guid PrescriptionId { get; set; }
    }
}