using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Business.Models.ViewModels;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class TestController : ITestController
    {
        ITestRepository testRepository;
        ITestValidator testValidator;


        public TestController(ITestRepository testRepository, ITestValidator testValidator)
        {
            this.testRepository = testRepository;
            this.testValidator = testValidator;
        }

        public void AddTest(Test newTest)
        {
            ThrowHelper.ThrowNullArgumentException(newTest, nameof(newTest));

            int newTestId = 0;

            bool testValidatorResult = testValidator.ValidateTest(newTest);

            if (testValidatorResult)
                newTestId = testRepository.Add(newTest);

            newTest.TestId = newTestId;
        }

        public List<TestViewModel> GetTestsList(int baseUserId, string title)
        {
            title = string.Format("%{0}%", title);

            List<Test> getResult = testRepository.Get(baseUserId, title);

            List<TestViewModel> result = getResult.Select(test => test.GetViewModel()).ToList();

            return result;
        }
    }
}
