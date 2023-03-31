using OnlineQuiz.Business.Models.Tests;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface ITestValidator
    {
        bool ValidateTest(Test test);
    }
}