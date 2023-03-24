using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public interface INotExecutedSPBuilder
    {
        INotExecutedSPBuilder AddParameter(string parameterName, object value);

        INotExecutedSPBuilder AddOutputParameter(string parameterName, SqlDbType dbType);

        IExecutedSPBuilder ExecuteNonQuery(out int rowsAffected);
        IExecutedSPBuilder ExecuteNonQuery();

        IExecutedSPBuilder ExecuteReader(out DataTable dataTable);
    }
}
