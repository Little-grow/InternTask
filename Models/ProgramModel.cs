using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Task.Infrastructure;

namespace Task.Models
{
    public class ProgramModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Program Title")]
        public string ProgramTitle { get; set; } = "";

        [DisplayName("Summary of the Program")]
        public string ProgramSummary { get; set; } = "";

        [Required]
        [DisplayName("Program Description")]
        public string ProgramDescription { get; set; } = "";

        [Required]
        [DisplayName("Key Skills required for the program")]
        public List<string> ProgramSkills { get; set; } = new List<string>();

        [DisplayName("Program Format")]
        public string ProgramBenefits { get; set; } = "";

        [DisplayName("Application Criteria")]
        public string ApplicationCriteria { get; set; } = "";

        [Required]
        [DisplayName("Program Type")]
        public ProgramType ProgramType { get; set; }

        [DisplayName("Program Start")]
        public DateOnly ProgramStart { get; set; }

        [Required]
        [DisplayName("Application Open")]
        public DateOnly ApplicationOpen { get; set; }

        [Required]
        [DisplayName("Application Close")]
        public DateOnly ApplicationClose { get; set; }

        public TimeSpan Duration { get; set; } // may change it to double or int 

        [Required]
        [DisplayName("Fully Remote")]
        public bool FullyRemote { get; set; }

        [RequiredIf("FullyRemote", false, ErrorMessage = "Program location is required if not fully remote.")]
        public string? ProgramLocation { get; set; }

        [DisplayName("Min Qualification")]
        public Qualification MinQualification { get; set; }

        [DisplayName("Max number of application")]
        public int MaxNumberOfApplication { get; set; }
    }
}
