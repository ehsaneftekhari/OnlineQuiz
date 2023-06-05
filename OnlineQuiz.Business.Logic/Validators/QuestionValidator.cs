using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Validators
{
    public class QuestionValidator : IQuestionValidator
    {
        IValidatorFunctions validatorFunctions;

        public QuestionValidator(IValidatorFunctions validatorFunctions)
        {
            this.validatorFunctions = validatorFunctions;
        }

        public bool ValidateQuestion(Question question)
        {
            ThrowHelper.ThrowNullArgumentException(question, nameof(question));

            validatorFunctions.CheckStringEmpty(question.text, "en_Question_EmptyText");
            validatorFunctions.CheckStringMaxLength(question.text, 4000, "en_Question_LongText");
            validatorFunctions.Check(question.order, order => order < 0, "en_Question_LessThanZeroOrder", ModelStatusEnum.Error);

            return question.IsFine();
        }
    }
}
