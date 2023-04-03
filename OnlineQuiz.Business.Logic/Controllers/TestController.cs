using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models.Tests;
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

        public bool EditTest(Test editedTest)
        {
            ThrowHelper.ThrowNullArgumentException(editedTest, nameof(editedTest));

            bool testValidatorResult = testValidator.ValidateTest(editedTest);

            bool result = false;

            if (testValidatorResult)
                result = testRepository.Edit(editedTest) == 1 ? true : false;

            return result;
        }

        public List<TestViewModel> GetTestsList(int baseUserId, string title)
        {
            title = string.Format("%{0}%", title);

            List<Test> getResult = testRepository.GetList(baseUserId, title);

            List<TestViewModel> result = getResult.Select(test => test.ToViewModel()).ToList();

            return result;
        }

        public Test GetTest(int testId)
        {
            Test getResult = testRepository.Get(testId);

            return getResult;
        }
    }
}
