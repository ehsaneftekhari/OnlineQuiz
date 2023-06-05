using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Logic.Abstractions.IServices
{
    public interface IQuestionService
    {
        List<QuestionViewModel> GetQuestionList(int sectionId);
        void AddQuestion(Question question);
    }
}