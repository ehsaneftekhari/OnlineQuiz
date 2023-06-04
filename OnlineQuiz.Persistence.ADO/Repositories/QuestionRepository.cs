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

        public int Add(Question newQuestion)
        {
            ThrowHelper.ThrowNullArgumentException(
                newQuestion, nameof(newQuestion),
                newQuestion.Text, nameof(newQuestion.Text),
                newQuestion.ImageAddress, nameof(newQuestion.ImageAddress),
                newQuestion.Score, nameof(newQuestion.Score),
                newQuestion.Duration, nameof(newQuestion.Duration),
                newQuestion.Order, nameof(newQuestion.Order)
                );

            int questionId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Question_Add]")
                .AddParameter("@SectionId", newQuestion)
                .AddParameter("@Text", newQuestion.Text.Value!)
                .AddParameter("@ImageAddress", newQuestion.ImageAddress.Value!)
                .AddParameter("@End", newQuestion.Score.Value!)
                .AddParameter("@Duration", newQuestion.Duration.Value!)
                .AddParameter("@Order", newQuestion.Order.Value!)
                .AddOutputParameter("QuestionId", SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameter<int>("QuestionId");

            return questionId;
        }
    }
}
