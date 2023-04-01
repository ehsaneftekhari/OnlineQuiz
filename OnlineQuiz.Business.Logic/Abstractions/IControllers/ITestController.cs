using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Business.Models.ViewModels;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface ITestController
    {
        void AddTest(Test newTest);

        List<TestViewModel> GetTestsList(int baseUserId, string title);
    }
}