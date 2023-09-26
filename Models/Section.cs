using Task.Repository;

namespace Task.Models
{
    public class Section
    {
        public void AddQuestion(IQuestionRepository questionRepository, string sectionName, Question question)
        {
            questionRepository.AddQuestionToSection(sectionName, question);
        }
    }
}
