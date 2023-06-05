using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Library;
using OnlineQuiz.Persistence.ADO.Builders;
using OnlineQuiz.Persistence.ADO.SqlDataAdapters;
using System.Data;
using static System.Formats.Asn1.AsnWriter;

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
                newQuestion.text, nameof(newQuestion.text),
                newQuestion.imageAddress, nameof(newQuestion.imageAddress),
                newQuestion.score, nameof(newQuestion.score),
                newQuestion.duration, nameof(newQuestion.duration),
                newQuestion.order, nameof(newQuestion.order)
                );

            int questionId = ADOSqlCommandBuilder.CreateSP("[Tests].[Usp_Question_Add]")
                .AddParameter("@SectionId", newQuestion.sectionId)
                .AddParameter("@Text", newQuestion.text.Value!, SqlDbType.NVarChar)
                .AddParameter("@ImageAddress", newQuestion.imageAddress.Value!, SqlDbType.VarChar)
                .AddParameter("@Score", newQuestion.score.Value!)
                .AddParameter("@Duration", newQuestion.duration.Value!, SqlDbType.Time)
                .AddParameter("@Order", newQuestion.order.Value!)
                .AddOutputParameter("QuestionId", SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameter<int>("QuestionId");

            return questionId;
        }
    }
}
