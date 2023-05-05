using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface ISectionController
    {
        void AddSection(int testId, Section section);
        List<SectionViewModel> GetSectionViewModelList(int testId);
        Section GetSection(int sectionId);
    }
}