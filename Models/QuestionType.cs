using Microsoft.Extensions.Options;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public enum QuestionType
    {
        
        Paragraph,
        [Display(Name ="Short Answer")]
        ShortAnswer,
        [Display(Name ="Yes/No")]
        YesNo,
        Dropdown,
        [Display(Name = "Multiple Choice")]
        MultipleChoice,
        Date,
        Number,
        [Display(Name ="File Upload")]
        FileUpload,
        [Display(Name ="Video Questions")]
        VideoQuestion
    }

    public class ParagraphQuestion : Question
    {
        public ParagraphQuestion()
        {
            Type = QuestionType.Paragraph;
        }
    }

    public class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion()
        {
            Type = QuestionType.MultipleChoice;
        }

        public List<string> options { get; set; } = new List<string>();

        [Required]
        public string Choice { get; set; } = string.Empty;
    }
}
