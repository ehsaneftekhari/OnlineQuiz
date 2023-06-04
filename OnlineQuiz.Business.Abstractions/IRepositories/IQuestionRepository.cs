using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    public interface IQuestionRepository
    {
        List<Question> GetList(int sectionId);
        int Add(Question newQuestion);
    }
}