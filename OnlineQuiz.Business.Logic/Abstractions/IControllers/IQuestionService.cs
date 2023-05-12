using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface IQuestionService
    {
        List<QuestionViewModel> GetQuestionList(int sectionId);
    }
}