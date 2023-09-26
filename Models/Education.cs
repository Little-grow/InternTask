using System.ComponentModel;

namespace Task.Models
{
    public class Education
    {
        public string SchoolName { get; set; } = "";
        public string Degree { get; set; } = "";
        [DisplayName("Your Course Name")]
        public string Course { get; set; } = "";
        
        public string Country { get; set; } = "";

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
      
        public bool IsCurrent { get; set; }
    }
}