using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Models.Tests;
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
                newSection, nameof(newSection),
                newSection.SectionTitle, nameof(newSection.SectionTitle),
                newSection.Start, nameof(newSection.Start),
                newSection.End, nameof(newSection.End),
                newSection.Duration, nameof(newSection.Duration),
                newSection.Order, nameof(newSection.Order),
                newSection.AttemptLimit, nameof(newSection.AttemptLimit),
                newSection.RandomizeQuestions, nameof(newSection.RandomizeQuestions),
                newSection.DisplayResult, nameof(newSection.DisplayResult),
                newSection.AllowEdit, nameof(newSection.AllowEdit)
                );

            int sectionId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Section_Add]")
                .AddParameter("@TestId", newSection.TestId)
                .AddParameter("@SectionTitle", newSection.SectionTitle.Value)
                .AddParameter("@Start", newSection.Start.Value, SqlDbType.DateTime)
                .AddParameter("@End", newSection.End.Value, SqlDbType.DateTime)
                .AddParameter("@Duration", newSection.Duration.Value, SqlDbType.Time)
                .AddParameter("@Order", newSection.Order.Value)
                .AddParameter("@AttemptLimit", newSection.AttemptLimit.Value)
                .AddParameter("@RandomizeQuestions", newSection.RandomizeQuestions.Value)
                .AddParameter("@DisplayResult", newSection.DisplayResult.Value)
                .AddParameter("@AllowEdit", newSection.AllowEdit.Value)
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

        public Section? GetSection(int sectionId)
        {
            DataTable dataTable;
            ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Section_Get]")
                .AddParameter("@SectionId", sectionId)
                .ExecuteReader(out dataTable);

            return new SectionDataTableAdapter().DataTableToList(dataTable).FirstOrDefault();
        }
    }
}
