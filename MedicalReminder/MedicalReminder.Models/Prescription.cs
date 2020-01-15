using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class Prescription:IDEntity
    {
        public Doctor Doctor { get; set; }
        public List<Drug> Drugs { get; set; }
    }
}