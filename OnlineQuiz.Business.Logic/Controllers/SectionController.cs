using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Library;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class SectionController : ISectionController
    {
        ISectionRepository sectionRepository;
        ISectionValidator sectionValidator;
        ISectionVerifier sectionVerifier;
        IAppMessageController appMessageController;

        public SectionController(ISectionRepository sectionRepository, ISectionValidator sectionValidator, ISectionVerifier sectionVerifier)
        {
            this.sectionRepository = sectionRepository;
            this.sectionValidator = sectionValidator;
            this.sectionVerifier = sectionVerifier;
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

            return result; ;
        }

        public (DeleteResult result, string message) DeleteSection(int sectionId)
        {
            DeleteResult result;
            string message = "";
            result = sectionRepository.DeleteSection(sectionId);
            if (result == DeleteResult.Failed)
                message = appMessageController.GetMessage("en_Section_SectionDidNotDeleted");
            return (result, message);
        }
    }
}
