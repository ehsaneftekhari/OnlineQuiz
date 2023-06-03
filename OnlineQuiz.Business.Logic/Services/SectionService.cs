using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Events.SectionEvents;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Library;
using Prism.Events;
using static System.Collections.Specialized.BitVector32;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Business.Logic.Services
{
    public class SectionService : ISectionService
    {
        ISectionRepository sectionRepository;
        ISectionValidator sectionValidator;
        ISectionVerifier sectionVerifier;
        IAppMessageService appMessageServices;
        ICustomEventAggregator eventAggregator;
        public SectionService(ISectionRepository sectionRepository, ISectionValidator sectionValidator, ISectionVerifier sectionVerifier, ICustomEventAggregator eventAggregator)
        {
            this.sectionRepository = sectionRepository;
            this.sectionValidator = sectionValidator;
            this.sectionVerifier = sectionVerifier;
            this.eventAggregator = eventAggregator;
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
    }
}
