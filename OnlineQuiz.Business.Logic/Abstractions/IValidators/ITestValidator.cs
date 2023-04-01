using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface ITestValidator
    {
        bool ValidateTest(Test test);
    }
}