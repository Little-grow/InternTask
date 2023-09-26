using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class ApplicationForm
    {
        [Key]
        public int Id { get; set; }

        public int ProgramId { get; set; }

        [Required]
        public UploadCoverLetterSection? UploadCoverLetter { get; set; }
        [Required]
        public PersonalInformationSection? PersonalInformation { get; set; }
        [Required]
        public ProfileSection? Profile { get; set; }
        [Required]
        public AdditionalQuestionsSection? AdditionalQuestions { get; set; }

        public Section? GetSectionByName(string sectionName)
        {
            switch (sectionName)
            {
                case nameof(PersonalInformationSection):
                    return PersonalInformation;
                case nameof(ProfileSection):
                    return Profile;
                case nameof(AdditionalQuestionsSection):
                    return AdditionalQuestions;
                default:
                    return null;
            }
        }
    }
}
