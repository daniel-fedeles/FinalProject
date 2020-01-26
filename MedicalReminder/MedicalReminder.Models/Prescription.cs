using System;
using System.Collections.Generic;

namespace MedicalReminder.Models
{
    public class Prescription:IDEntity
    {
        public DateTime DateOfPresproption { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual User User { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
    }
}