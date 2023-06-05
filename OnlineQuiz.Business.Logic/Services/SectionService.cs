using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Events.SectionEvents;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Library;
using OnlineQuiz.Persistence.ADO.Repositories;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Business.Logic.Services
{
    public class SectionService : ISectionService
    {
        ISectionRepository sectionRepository;
        IQuestionRepository questionRepository;
        ISectionValidator sectionValidator;
        ISectionVerifier sectionVerifier;
        IAppMessageService appMessageServices;
        ICustomEventAggregator eventAggregator;

        public SectionService(ISectionRepository sectionRepository, ISectionValidator sectionValidator, ISectionVerifier sectionVerifier, ICustomEventAggregator eventAggregator, IQuestionRepository questionRepository)
        {
            this.sectionRepository = sectionRepository;
            this.sectionValidator = sectionValidator;
            this.sectionVerifier = sectionVerifier;
            this.eventAggregator = eventAggregator;
            this.questionRepository = questionRepository;
        }

        public void AddSection(int testId, Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            int newSectionId = 0;

            bool sectionValidatorResult = sectionValidator.ValidateSection(section);
            bool sectionVerifierResult = sectionValidatorResult && sectionVerifier.VerifySection(section);

            if (sectionVerifierResult && sectionValidatorResult)
                newSectionId = sectionRepository.Add(section);

            section.SectionId = newSectionId;

            if (section.HasId())
                eventAggregator.Publish<SectionAddEvent, SectionEventsPayload>(new() { Section = section });
        }

        public List<SectionViewModel> GetSectionViewModelList(int testId)
        {
            List<Section> getResult = sectionRepository.GetList(testId);

            List<SectionViewModel> result = getResult.Select(test => test.ToViewModel()).ToList();

            return result;
        }

        public Section GetSection(int sectionId) => sectionRepository.GetSection(sectionId);

        public bool EditSection(Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            bool sectionValidatorResult = sectionValidator.ValidateSection(section);
            bool sectionVerifierResult = sectionValidatorResult && sectionVerifier.VerifySection(section);

            bool result = false;
            if (sectionVerifierResult && sectionValidatorResult)
                result = sectionRepository.EditSection(section) == 1;

            if(result)
                eventAggregator.Publish<SectionUpdateEvent, SectionEventsPayload>(new() { Section = section });

            return result;
        }

        public (DeleteResult result, string message) DeleteSection(int sectionId)
        {
            DeleteResult result;
            string message = "";

            var section = GetSection(sectionId);

            result = sectionRepository.DeleteSection(sectionId);

            if (result == DeleteResult.Failed)
                message = appMessageServices.GetMessage("en_Section_SectionDidNotDeleted");

            if(result != DeleteResult.Failed)
                eventAggregator.Publish<SectionDeleteEvent, SectionEventsPayload>(new() { Section = section });
            
            return (result, message);
        }

        public TimeSpan GetQuestionsDurationSum(int sectionId)
        {
            var questions = questionRepository.GetList(sectionId);

            if (questions != null)
            {
                TimeSpan durationSum = new TimeSpan();

                foreach (var question in questions)
                {
                    if (question.duration.Value != null)
                        durationSum += question.duration.Value.Value;
                }

                return durationSum;
            }

            return TimeSpan.Zero;
        }

        public TimeSpan GetRemainingDuration(int sectionId, out Section section)
        {
            section = sectionRepository.GetSection(sectionId);
            var sectionDurationCapacity = section.Duration;
            var QuestionsDurationSum = GetQuestionsDurationSum(sectionId);

            if (sectionDurationCapacity.HasValue)
                return sectionDurationCapacity.Value!.Value - QuestionsDurationSum;

            return TimeSpan.Zero;
        }
    }
}
