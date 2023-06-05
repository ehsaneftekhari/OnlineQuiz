using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Logic.Abstractions.IServices
{
    public interface ISectionService
    {
        void AddSection(int testId, Section section);
        List<SectionViewModel> GetSectionViewModelList(int testId);
        Section GetSection(int sectionId);
        bool EditSection(Section section);
        (DeleteResult result, string message) DeleteSection(int sectionId);
        TimeSpan GetQuestionsDurationSum(int sectionId);
        TimeSpan GetRemainingDuration(int sectionId, out Section section);
    }
}