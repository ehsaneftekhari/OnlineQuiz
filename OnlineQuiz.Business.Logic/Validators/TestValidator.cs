using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Tests;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Validators
{
    public class TestValidator : ITestValidator
    {
        IValidatorFunctions validatorFunctions;

        public TestValidator(IValidatorFunctions validatorFunctions)
        {
            ThrowHelper.ThrowNullArgumentException(validatorFunctions, nameof(validatorFunctions));

            this.validatorFunctions = validatorFunctions;
        }

        public bool ValidateTest(Test test)
        {
            ThrowHelper.ThrowNullArgumentException(test, nameof(test));

            validatorFunctions.CheckStringEmpty(test.Title, "en_Test_EmptyTitle");
            validatorFunctions.CheckStringMaxLength(test.Title, 32, "en_BTest_LongTitle");

            return test.IsFine();
        }
    }
}
