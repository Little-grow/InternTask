using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public enum ProgramType
    {
        [Display(Name = "Full Time")]
        FullTime,
        [Display(Name = "Part Time")]
        PartTime,
        [Display(Name = "Online")]
        Online
    }
}
