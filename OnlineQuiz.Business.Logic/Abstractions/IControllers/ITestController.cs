using OnlineQuiz.Business.Models.Tests;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface ITestController
    {
        void AddTest(Test newTest);
    }
}