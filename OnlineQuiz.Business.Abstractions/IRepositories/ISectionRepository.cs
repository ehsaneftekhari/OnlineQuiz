using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface ISectionRepository
    {
        List<Section> GetList(int testId);
    }
}