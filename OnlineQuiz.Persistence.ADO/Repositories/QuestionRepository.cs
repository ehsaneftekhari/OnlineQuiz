using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Library;
using OnlineQuiz.Persistence.ADO.Builders;
using OnlineQuiz.Persistence.ADO.SqlDataAdapters;
using System.Data;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public List<Question> GetList(int sectionId)
        {
            ThrowHelper.ThrowNullArgumentException(sectionId, nameof(sectionId));

            DataTable dataTable;
            ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Question_GetList]")
                .AddParameter("@SectionId", sectionId)
                .ExecuteReader(out dataTable);

            return new QuestionDataTableAdapter().DataTableToList(dataTable);
        }
    }
}
