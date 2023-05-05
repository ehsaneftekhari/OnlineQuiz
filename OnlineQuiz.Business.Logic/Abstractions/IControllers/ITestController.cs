using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface ITestController
    {
        void AddTest(Test newTest);

        bool EditTest(Test editedTest);

        List<TestViewModel> GetTestsList(int baseUserId, string title);

        Test GetTest(int testId);

        TimeSpan GetSectionsDurationSum(int testId);
    }
}