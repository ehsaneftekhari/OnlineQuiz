using System.Data;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public interface IADONotExecutedSPBuilder
    {
        IADONotExecutedSPBuilder AddParameter(string parameterName, object value);

        IADONotExecutedSPBuilder AddParameter(string parameterName, object value, SqlDbType? dbType);

        IADONotExecutedSPBuilder AddOutputParameter(string parameterName, SqlDbType dbType);

        IADOExecutedSPBuilder ExecuteNonQuery(out int rowsAffected);

        IADOExecutedSPBuilder ExecuteNonQuery();

        IADOExecutedSPBuilder ExecuteReader(out DataTable dataTable);
    }
}
