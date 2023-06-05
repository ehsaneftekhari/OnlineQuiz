using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Library;
using System.Data;

namespace OnlineQuiz.Persistence.ADO.SqlDataAdapters
{
    internal class QuestionDataTableAdapter : DataTableAdapter<Question>
    {
        public override Question ConvertDataRow(DataRow dataRow)
        {
            ThrowHelper.ThrowNullArgumentException(dataRow, nameof(dataRow));

            SqlDateAdapter adapter = new SqlDateAdapter();

            int QuestionId      = adapter.ToInt32(dataRow["QuestionId"], 0);
            int SectionId       = adapter.ToInt32(dataRow["SectionId"], 0);
            string Text         = adapter.ToString(dataRow["Text"]);
            string ImageAddress = adapter.ToString(dataRow["ImageAddress"]);
            double? Score       = adapter.ToDouble(dataRow["Score"]);
            TimeSpan? Duration  = adapter.ToTimeSpan(dataRow["Duration"]);
            int? Order          = adapter.ToInt32(dataRow["Order"]);

            return new(QuestionId, SectionId, Text, ImageAddress, Score, Duration, Order);
        }
    }
}
