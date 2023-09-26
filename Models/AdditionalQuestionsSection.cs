using System.ComponentModel;

namespace Task.Models
{
    public class AdditionalQuestionsSection: Section
    {
        [DisplayName("Please tell me about yourself in less than 500 words")]
        public Question Bigraophy { get; set; }

        [DisplayName("Please select the year of graduation from the list below")]
        public Question GraduationYear { get; set; }

        [DisplayName("Have you ever been rejected by the UK embassy?")]
        public Question UKRejection { get; set; }
    }

     
}
