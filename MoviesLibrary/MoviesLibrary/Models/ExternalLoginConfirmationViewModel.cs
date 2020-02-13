using System.ComponentModel.DataAnnotations;

namespace MoviesLibrary.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
