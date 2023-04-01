using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface IQuestionController
    {
        List<QuestionViewModel> GetQuestionList(int sectionId);
    }
}