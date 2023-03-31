using OnlineQuiz.Business.Models.Tests;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface ITestRepository
    {
        int Add(Test test);
    }
}