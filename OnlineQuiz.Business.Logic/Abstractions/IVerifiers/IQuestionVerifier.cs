using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Logic.Abstractions.IVerifiers
{
    public interface IQuestionVerifier
    {
        bool VerifyQuestion(Question section);
    }
}
