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
        public int Add(Section newSection)
        {
            ThrowHelper.ThrowNullArgumentException(
                newSection, nameof(newSection)
                );

            int sectionId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Section_Add]")
                .AddParameter("@TestId", newSection.TestId)
                .AddParameter("@SectionTitle", newSection.SectionTitle)
                .AddParameter("@Start", newSection.Start)
                .AddParameter("@End", newSection.End)
                .AddParameter("@Duration", newSection.Duration)
                .AddParameter("@Order", newSection.Order)
                .AddParameter("@AttemptLimit", newSection.AttemptLimit)
                .AddParameter("@RandomizeQuestions", newSection.RandomizeQuestions)
                .AddParameter("@DisplayResult", newSection.DisplayResult)
                .AddParameter("@AllowEdit", newSection.AllowEdit)
                .AddOutputParameter("SectionId", SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameter<int>("SectionId");

            return sectionId;
        }

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
