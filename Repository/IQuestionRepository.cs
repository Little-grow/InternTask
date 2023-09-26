using Task.Models;

namespace Task.Repository
{
    public interface IQuestionRepository
    {
        void AddQuestionToSection(string sectionName, Question question);
        List<Question> GetQuestionsBySection(string sectionName);
    }
}