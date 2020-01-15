using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalReminder.Models
{
    public class IDEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}