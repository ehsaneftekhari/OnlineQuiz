using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.Events.QuestionEvents;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Events.SectionEvents;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Library;
using OnlineQuiz.Persistence.ADO.Repositories;

namespace OnlineQuiz.Business.Logic.Services
{
    public class QuestionService : IQuestionService
    {
        readonly IQuestionRepository questionRepository;
        readonly IQuestionValidator questionValidator;
        readonly IQuestionVerifier questionVerifier;
        readonly ICustomEventAggregator eventAggregator;

        public QuestionService(IQuestionRepository questionRepository,
                               IQuestionValidator questionValidator,
                               IQuestionVerifier questionVerifier,
                               ICustomEventAggregator eventAggregator)
        {
            this.questionRepository = questionRepository;
            this.questionValidator = questionValidator;
            this.questionVerifier = questionVerifier;
            this.eventAggregator = eventAggregator;
        }

        public List<QuestionViewModel> GetQuestionList(int sectionId)
        {
            List<Question> getResult = questionRepository.GetList(sectionId);

            List<QuestionViewModel> result = getResult.Select(test => test.ToViewModel()).ToList();
            return result;
        }

        public void AddQuestion(Question question)
        {
            ThrowHelper.ThrowNullArgumentException(question, nameof(question));

            int newQuestion = 0;

            bool questionValidatorResult = questionValidator.ValidateQuestion(question);
            bool questionVerifierResult = questionValidatorResult && questionVerifier.VerifyQuestion(question);

            if (questionVerifierResult && questionValidatorResult)
                newQuestion = questionRepository.Add(question);

            question.questionId = newQuestion;

            if (question.HasId())
                eventAggregator.Publish<QuestionAddEvent, QuestionEventsPayload>(new() { Question = question });
        }
    }
}
