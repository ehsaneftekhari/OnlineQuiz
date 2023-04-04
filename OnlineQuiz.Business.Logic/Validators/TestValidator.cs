using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Tests;
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
            validatorFunctions.CheckStringMaxLength(test.Title, 32, "en_Test_LongTitle");

            bool RandomAll = test.RandomizeType.Value == RandomizeType.RandomAllSections;
            bool NotNullStart = test.Start.Value != null;
            bool NotNullEnd = test.End.Value != null;

            bool CheckTime = false;

            if (RandomAll)
                CheckTime = true;

            if (NotNullStart || NotNullEnd)
                CheckTime = true;

            if (CheckTime)
            {
                if (NotNullStart && NotNullEnd)
                {
                    validatorFunctions.Check(test.Start, start => start == test.End.Value, "en_Test_SameStart&End", ModelStatusEnum.Error);
                    validatorFunctions.Check(test.End, End => End == test.Start.Value, "en_Test_SameStart&End", ModelStatusEnum.Error);

                    validatorFunctions.Check(test.Start, start => start > test.End.Value, "en_Test_LateStart", ModelStatusEnum.Error);
                    validatorFunctions.Check(test.End, End => End < test.Start.Value, "en_Test_EarlierEnd", ModelStatusEnum.Error);
                }
                else
                {
                    validatorFunctions.Check(test.Start, start => start == null && start == new DateTime(), "en_Test_NotSeatedStart", ModelStatusEnum.Error);
                    validatorFunctions.Check(test.End, End => End == null && End == new DateTime(), "en_Test_NotSeatedEnd", ModelStatusEnum.Error);
                }
            }

            return test.IsFine();
        }
    }
}
