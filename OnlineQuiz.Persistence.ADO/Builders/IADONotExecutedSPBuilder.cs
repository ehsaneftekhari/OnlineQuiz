using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public interface IADONotExecutedSPBuilder
    {
        IADONotExecutedSPBuilder AddParameter(string parameterName, object value);

        IADONotExecutedSPBuilder AddOutputParameter(string parameterName, SqlDbType dbType);

        IADOExecutedSPBuilder ExecuteNonQuery(out int rowsAffected);

        IADOExecutedSPBuilder ExecuteNonQuery();

        IADOExecutedSPBuilder ExecuteReader(out DataTable dataTable);
    }
}
