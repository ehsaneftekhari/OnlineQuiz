using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using System.Collections.Generic;
using System.Data;

namespace OnlineQuiz.Persistence.ADO
{
    public class DataTableAdapter
    {
        public List<Test> DataTableToTestList(DataTable dataTable)
        {
            ThrowHelper.ThrowNullArgumentException(dataTable, nameof(dataTable));

            List<Test> result = new List<Test>();

            foreach (DataRow row in dataTable.Rows)
            {
                result.Add(DataRowToTest(row));
            }

            return result;
        }

        public Test DataRowToTest(DataRow dataRow)
        {
            ThrowHelper.ThrowNullArgumentException(dataRow, nameof(dataRow));

            int TestId = Convert.ToInt32(dataRow["TestId"]);
            string Title = Convert.ToString(dataRow["Title"])!;
            bool Published = Convert.ToBoolean(dataRow["Published"]);
            bool RandomizeSections = Convert.ToBoolean(dataRow["RandomizeSections"]);

            return new(TestId, 0, Title, Published, RandomizeSections);
        }
    }
}
