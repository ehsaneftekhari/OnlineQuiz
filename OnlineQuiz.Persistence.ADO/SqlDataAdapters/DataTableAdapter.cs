using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
