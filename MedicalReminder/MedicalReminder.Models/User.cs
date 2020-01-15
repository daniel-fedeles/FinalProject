using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalReminder.Models
{
    public class User:IDEntity
    {
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [EmailAddress]
        [MaxLength(250)]
        public string Email { get; set; }



    }


}
