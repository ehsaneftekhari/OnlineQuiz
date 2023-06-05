using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface IQuestionValidator
    {
        bool ValidateQuestion(Question section);
    }
}
