using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Sections;
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

        public List<SectionViewModel> GetSectionList(int testId)
        {
            List<Section> getResult = sectionRepository.GetList(testId);

            List<SectionViewModel> result = getResult.Select(test => test.ToViewModel()).ToList();

            return result;
        }
    }
}
