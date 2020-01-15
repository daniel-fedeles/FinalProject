using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalReminder.Models
{
    public class Drug:IDEntity
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        public decimal Weight { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime? NrOfDaysFromOpening { get; set; }

    }
}