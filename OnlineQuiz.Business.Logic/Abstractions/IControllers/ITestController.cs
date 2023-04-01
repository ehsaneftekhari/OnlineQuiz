using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface ITestController
    {
        void AddTest(Test newTest);

        List<TestViewModel> GetTestsList(int baseUserId, string title);

        Test GetTest(int testId);
    }
}