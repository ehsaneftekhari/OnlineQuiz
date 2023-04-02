using OnlineQuiz.Library;
using System.Data;

namespace OnlineQuiz.Persistence.ADO.SqlDataAdapters
{
    public abstract class DataTableAdapter<T>
    {
        public List<T> DataTableToList(DataTable dataTable)
        {
            ThrowHelper.ThrowNullArgumentException(dataTable, nameof(dataTable));

            List<T> result = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                result.Add(ConvertDataRow(row));
            }

            return result;
        }

        public abstract T ConvertDataRow(DataRow dataRow);
    }
}
