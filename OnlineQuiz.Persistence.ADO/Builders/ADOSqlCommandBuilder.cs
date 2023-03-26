using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public class ADOSqlCommandBuilder : IADONotExecutedSPBuilder, IADOExecutedSPBuilder
    {
        private readonly SqlCommand _sqlCommand;
        //public SqlCommand SqlCommand => _sqlCommand; 

        private ADOSqlCommandBuilder(string cmdText)
        {
            SqlConnection connection = ADOSqlConnectionCreator.Create();
            _sqlCommand = new SqlCommand(cmdText, connection);
        }

        public static IADONotExecutedSPBuilder CreateSP(string SpName)
        {
            ADOSqlCommandBuilder sqlCommandBuilder = new ADOSqlCommandBuilder(SpName);
            sqlCommandBuilder._sqlCommand.CommandType = CommandType.StoredProcedure;

            return sqlCommandBuilder;
        }

        public IADONotExecutedSPBuilder AddParameter(string parameterName, object value)
        {
            _sqlCommand.Parameters.Add(new SqlParameter(parameterName, value));
            return this;
        }

        public IADONotExecutedSPBuilder AddOutputParameter(string parameterName, SqlDbType dbType)
        {
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
            if (parameterName == null)
                throw new ArgumentNullException();

            if (parameterName.Length == 0)
                throw new ArgumentException();

            return _sqlCommand.Parameters[parameterName].Value;
        }

        public Type GetValueOfOutputParameters<Type>(string parameterName)
        {
            if (parameterName == null)
                throw new ArgumentNullException();

            if (parameterName.Length == 0)
                throw new ArgumentException();

            return (Type)(_sqlCommand.Parameters[parameterName].Value);
        }

        public IDictionary<string, object> GetValueOfOutputParameters(params string[] parameterNames)
        {
            if (parameterNames == null)
                throw new ArgumentNullException();

            if (parameterNames.Length == 0)
                throw new ArgumentException();

            IDictionary<string, object> keyValuePairs = new Dictionary<string, object>();

            foreach (string parameterName in parameterNames)
            {
                keyValuePairs.Add(parameterName, GetValueOfOutputParameters(parameterName));
            }

            return keyValuePairs;
        }
    }
}
