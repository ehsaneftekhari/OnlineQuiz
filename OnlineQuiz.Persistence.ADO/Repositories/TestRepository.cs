using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Tests;
using OnlineQuiz.Library;
using ADOSqlCommandBuilder = OnlineQuiz.Persistence.ADO.Builders.ADOSqlCommandBuilder;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    internal class TestRepository : ITestRepository
    {
        private IAppMessageRepository appMessageRepository;

        public TestRepository(IAppMessageRepository appMessageRepository)
        {
            this.appMessageRepository = appMessageRepository;
        }

        public int Add(Test test)
        {
            ThrowHelper.ThrowNullArgumentException(
                test, nameof(test),
                test.BaseUserId, nameof(test.BaseUserId),
                test.Title, nameof(test.Title),
                test.Published, nameof(test.Published),
                test.RandomizeSections, nameof(test.RandomizeSections)
            );

            var TestId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Test_Add]")
                .AddParameter("@BaseUserId", test.BaseUserId.Value)
                .AddParameter("@Title", test.Title.Value)
                .AddParameter("@Published", test.Published.Value)
                .AddParameter("@RandomizeSections", test.RandomizeSections.Value)
                .AddOutputParameter("@TestId", System.Data.SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameters("@TestId");

            return (int)TestId;
        }

    }
}
