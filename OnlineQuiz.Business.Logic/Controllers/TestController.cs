using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Tests;
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
            
            if(testValidatorResult)
                newTestId = testRepository.Add(newTest);

            newTest.TestId = newTestId;
        }
    }
}
