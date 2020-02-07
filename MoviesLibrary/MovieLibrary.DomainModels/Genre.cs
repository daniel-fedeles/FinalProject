using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.DomainModels
{
    public class Genre
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}