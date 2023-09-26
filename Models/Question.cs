using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class Question
    {
        [Required]
        public string Text { get; set; } = string.Empty;
        public QuestionType Type { get; set; }
    }    
}
