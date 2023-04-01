using OnlineQuiz.Business.Models.Models.Tests;
using System.Data;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface ITestRepository
    {
        int Add(Test test);

        List<Test> Get(int baseUserId, string title);
    }
}