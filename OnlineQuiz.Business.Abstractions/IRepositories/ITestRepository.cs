using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface ITestRepository
    {
        int Add(Test test);

        List<Test> GetList(int baseUserId, string title);

        Test Get(int testId);
    }
}