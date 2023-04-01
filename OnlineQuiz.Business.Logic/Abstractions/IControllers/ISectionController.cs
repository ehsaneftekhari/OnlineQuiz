using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface ISectionController
    {
        List<SectionViewModel> GetSectionList(int testId);
    }
}