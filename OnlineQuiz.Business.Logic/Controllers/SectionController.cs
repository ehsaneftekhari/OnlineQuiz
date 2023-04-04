using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Validators;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Library;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class SectionController : ISectionController
    {
        ISectionRepository sectionRepository;


        public SectionController(ISectionRepository sectionRepository)
        {
            this.sectionRepository = sectionRepository;
        }
        
        public void AddSection(Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            int newSectionId = 0;

            //bool sectionValidatorResult = testValidator.ValidateTest(newTest);
        }

        public List<SectionViewModel> GetSectionList(int testId)
        {
            List<Section> getResult = sectionRepository.GetList(testId);

            List<SectionViewModel> result = getResult.Select(test => test.ToViewModel()).ToList();

            return result;
        }
    }
}
