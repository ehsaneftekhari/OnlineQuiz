using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Library;
using OnlineQuiz.Persistence.ADO.Builders;
using OnlineQuiz.Persistence.ADO.SqlDataAdapters;
using System.Data;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        public List<Section> GetList(int testId)
        {
            ThrowHelper.ThrowNullArgumentException(testId, nameof(testId));

            DataTable dataTable;
            ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Section_GetList]")
                .AddParameter("@TestId", testId)
                .ExecuteReader(out dataTable);

            return new SectionDataTableAdapter().DataTableToList(dataTable);
        }
    }
}
