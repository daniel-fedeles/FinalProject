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

        public ICollection<Prescription> Prescription { get; set; }
    }
}