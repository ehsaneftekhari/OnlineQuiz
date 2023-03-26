using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    internal class ADOSqlConnectionCreator
    {
        private static string ConnectionString = "data source=EHSANVIVOBOOK\\EHSANSQLSERVER;initial catalog=OnlineTestDB;integrated security=true";
        private static SqlConnection? connection;
        public static SqlConnection Create()
        {
            if (connection == null)
                connection = new SqlConnection(ConnectionString);

            return connection;
        }
    }
}
