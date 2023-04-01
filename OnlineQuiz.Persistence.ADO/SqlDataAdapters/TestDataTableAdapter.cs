using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using System.Collections.Generic;
using System.Data;

namespace OnlineQuiz.Persistence.ADO.SqlDataAdapters
{
    public class TestDataTableAdapter : DataTableAdapter<Test>
    {
        public override Test ConvertDataRow(DataRow dataRow)
        {
            ThrowHelper.ThrowNullArgumentException(dataRow, nameof(dataRow));

            SqlDateAdapter adapter = new SqlDateAdapter();

            int TestId             = adapter.ToInt32(dataRow["TestId"], 0);
            string Title           = adapter.ToString(dataRow["Title"])!;
            bool Published         = adapter.ToBoolean(dataRow["Published"], false);
            bool RandomizeSections = adapter.ToBoolean(dataRow["RandomizeSections"], false);

            return new(TestId, 0, Title, Published, RandomizeSections);
        }
    }
}
