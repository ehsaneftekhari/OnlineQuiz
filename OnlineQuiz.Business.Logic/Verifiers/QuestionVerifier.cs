using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Verifiers
{
    public class QuestionVerifier : IQuestionVerifier
    {
        readonly ISectionService sectionService;
        readonly IValidatorFunctions validatorFunctions;

        public QuestionVerifier(IValidatorFunctions validatorFunctions,
                                ISectionService sectionService)
        {
            this.validatorFunctions = validatorFunctions;
            this.sectionService = sectionService;
        }

        public bool VerifyQuestion(Question question)
        {
            ThrowHelper.ThrowNullArgumentException(question, nameof(question));

            var remainingDuration = sectionService.GetRemainingDuration(question.sectionId, out var section);

            if (section.RandomizeQuestions.IsFine() && !section.RandomizeQuestions.Value)
            {
                validatorFunctions.Check(question.order,
                    order => order > 0,
                    "en_Question_LessThanOneOrderOnNonRandomizeQuestions",
                    ModelStatusEnum.Error);
            }

            if (section.Duration.HasValue && question.duration.HasValue)
                validatorFunctions.Check(question.duration,
                         duration => duration > remainingDuration,
                         "en_Section_TestAndSectionNotSameStart",
                         ModelStatusEnum.Error);


            return question.IsFine();
        }
    }
}
