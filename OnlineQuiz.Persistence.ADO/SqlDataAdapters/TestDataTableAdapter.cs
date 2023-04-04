using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using System.Data;

namespace OnlineQuiz.Persistence.ADO.SqlDataAdapters
{
    public class TestDataTableAdapter : DataTableAdapter<Test>
    {
        public override Test ConvertDataRow(DataRow dataRow)
        {
            ThrowHelper.ThrowNullArgumentException(dataRow, nameof(dataRow));

            SqlDateAdapter adapter = new SqlDateAdapter();

            int TestId = adapter.ToInt32(dataRow["TestId"], 0);
            int BaseUserId = adapter.ToInt32(dataRow["BaseUserId"], 0);
            string Title = adapter.ToString(dataRow["Title"])!;
            DateTime? Start = adapter.ToDataTime(dataRow["Start"]);
            DateTime? End = adapter.ToDataTime(dataRow["End"]);
            bool Published = adapter.ToBoolean(dataRow["Published"], false);
            RandomizeType RandomizeType = (RandomizeType)adapter.ToInt32(dataRow["RandomizeType"])!;

            return new(TestId, BaseUserId, Title, Start, End, Published, RandomizeType);

        }
    }
}
