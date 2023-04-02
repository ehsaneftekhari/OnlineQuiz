using OnlineQuiz.Library;
using System.Data;
using System.Data.SqlClient;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public class ADOSqlCommandBuilder : IADONotExecutedSPBuilder, IADOExecutedSPBuilder
    {
        private readonly SqlCommand _sqlCommand;
        //public SqlCommand SqlCommand => _sqlCommand; 

        private ADOSqlCommandBuilder(string cmdText)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(cmdText, nameof(cmdText));

            SqlConnection connection = ADOSqlConnectionCreator.Create();
            _sqlCommand = new SqlCommand(cmdText, connection);
        }

        public static IADONotExecutedSPBuilder CreateSP(string SpName)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(SpName, nameof(SpName));

            ADOSqlCommandBuilder sqlCommandBuilder = new ADOSqlCommandBuilder(SpName);
            sqlCommandBuilder._sqlCommand.CommandType = CommandType.StoredProcedure;

            return sqlCommandBuilder;
        }

        public IADONotExecutedSPBuilder AddParameter(string parameterName, object value)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(parameterName, nameof(parameterName));
            ThrowHelper.ThrowNullArgumentException(value, nameof(value));

            _sqlCommand.Parameters.Add(new SqlParameter(parameterName, value));
            return this;
        }

        public IADONotExecutedSPBuilder AddOutputParameter(string parameterName, SqlDbType dbType)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(parameterName, nameof(parameterName));
            ThrowHelper.ThrowNullArgumentException(dbType, nameof(dbType));

            _sqlCommand.Parameters.Add(new SqlParameter(parameterName, dbType));
            _sqlCommand.Parameters[parameterName].Direction = ParameterDirection.Output;
            return this;
        }

        public IADOExecutedSPBuilder ExecuteNonQuery(out int rowsAffected)
        {
            if (_sqlCommand.Connection.State != ConnectionState.Open)
                _sqlCommand.Connection.Open();

            rowsAffected = _sqlCommand.ExecuteNonQuery();

            _sqlCommand.Connection.Close();

            return this;
        }

        public IADOExecutedSPBuilder ExecuteNonQuery()
        {
            return ExecuteNonQuery(out int _);
        }

        public IADOExecutedSPBuilder ExecuteReader(out DataTable dataTable)
        {
            dataTable = new DataTable();

            if (_sqlCommand.Connection.State != ConnectionState.Open)
                _sqlCommand.Connection.Open();

            dataTable.Load(_sqlCommand.ExecuteReader());

            _sqlCommand.Connection.Close();

            return this;
        }

        public object GetValueOfOutputParameters(string parameterName)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(parameterName, nameof(parameterName));

            return _sqlCommand.Parameters[parameterName].Value;
        }

        public Type GetValueOfOutputParameters<Type>(string parameterName)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(parameterName, nameof(parameterName));

            return (Type)(_sqlCommand.Parameters[parameterName].Value);
        }

        public IDictionary<string, object> GetValueOfOutputParameters(params string[] parameterNames)
        {
            ThrowHelper.ThrowNullOrEmptyArrayException(parameterNames, nameof(parameterNames));

            IDictionary<string, object> keyValuePairs = new Dictionary<string, object>();

            foreach (string parameterName in parameterNames)
            {
                keyValuePairs.Add(parameterName, GetValueOfOutputParameters(parameterName));
            }

            return keyValuePairs;
        }
    }
}
