using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface ISectionRepository
    {
        int Add(Section newSection);
        List<Section> GetList(int testId);
    }
}