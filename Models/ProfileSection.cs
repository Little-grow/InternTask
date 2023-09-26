using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class ProfileSection : Section
    {
        public List<Experience>? experience { get; set; }
       
        public List<Education>? educations { get; set; } 

        [Required]
        public IFormFile resume { get; set; }
    }
}