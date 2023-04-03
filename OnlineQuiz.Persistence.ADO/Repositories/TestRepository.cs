using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using OnlineQuiz.Persistence.ADO.SqlDataAdapters;
using System.Data;
using ADOSqlCommandBuilder = OnlineQuiz.Persistence.ADO.Builders.ADOSqlCommandBuilder;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    internal class TestRepository : ITestRepository
    {
        public TestRepository() { }

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
                .AddParameter("@Title", test.Title.Value!)
                .AddParameter("@Published", test.Published.Value)
                .AddParameter("@RandomizeSections", test.RandomizeSections.Value)
                .AddOutputParameter("@TestId", System.Data.SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameter("@TestId");

            return (int)TestId;
        }

        public int Edit(Test test)
        {
            ThrowHelper.ThrowNullArgumentException(
                test, nameof(test),
                test.Title, nameof(test.Title),
                test.Published, nameof(test.Published),
                test.RandomizeSections, nameof(test.RandomizeSections)
            );

            int rowsAffected;

            ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Test_Edit]")
                .AddParameter("@TestId", test.TestId!)
                .AddParameter("@Title", test.Title.Value!)
                .AddParameter("@Published", test.Published.Value)
                .AddParameter("@RandomizeSections", test.RandomizeSections.Value)
                .ExecuteNonQuery(out rowsAffected);

            return rowsAffected;
        }

        public List<Test> GetList(int baseUserId, string title)
        {
            ThrowHelper.ThrowNullArgumentException(title, nameof(title));

            DataTable dataTable;
            var TestId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Test_GetList]")
                .AddParameter("@BaseUserId", baseUserId)
                .AddParameter("@Title", title)
                .ExecuteReader(out dataTable);

            return new TestDataTableAdapter().DataTableToList(dataTable);
        }

        public Test Get(int testId)
        {
            DataTable dataTable;
            var TestId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Test_Get]")
                .AddParameter("@TestId", testId)
                .ExecuteReader(out dataTable);

            return new TestDataTableAdapter().DataTableToList(dataTable).First();
        }
    }
}
