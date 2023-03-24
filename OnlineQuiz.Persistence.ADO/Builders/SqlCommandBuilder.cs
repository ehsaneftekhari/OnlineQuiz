using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public class SqlCommandBuilder : INotExecutedSPBuilder, IExecutedSPBuilder
    {
        private readonly SqlCommand _sqlCommand;
        //public SqlCommand SqlCommand => _sqlCommand; 

        private SqlCommandBuilder(string cmdText)
        {
            SqlConnection connection = SqlConnectionCreator.Create();
            _sqlCommand = new SqlCommand(cmdText, connection);
        }

        public static INotExecutedSPBuilder CreateSP(string SpName)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(SpName);
            sqlCommandBuilder._sqlCommand.CommandType = CommandType.StoredProcedure;

            return sqlCommandBuilder;
        }

        public INotExecutedSPBuilder AddParameter(string parameterName, object value)
        {
            _sqlCommand.Parameters.Add(new SqlParameter(parameterName, value));
            return this;
        }

        public INotExecutedSPBuilder AddOutputParameter(string parameterName, SqlDbType dbType)
        {
            _sqlCommand.Parameters.Add(new SqlParameter(parameterName, dbType));
            _sqlCommand.Parameters[parameterName].Direction = ParameterDirection.Output;
            return this;
        }

        public IExecutedSPBuilder ExecuteNonQuery(out int rowsAffected)
        {
            if (_sqlCommand.Connection.State != ConnectionState.Open)
                _sqlCommand.Connection.Open();

            rowsAffected = _sqlCommand.ExecuteNonQuery();

            _sqlCommand.Connection.Close();

            return this;
        }

        public IExecutedSPBuilder ExecuteNonQuery()
        {
            return ExecuteNonQuery(out int _);
        }

        public IExecutedSPBuilder ExecuteReader(out DataTable dataTable)
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
