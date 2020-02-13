using System.ComponentModel.DataAnnotations;

namespace MoviesLibrary.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}