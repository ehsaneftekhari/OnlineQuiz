﻿using System.Data.SqlClient;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    internal class ADOSqlConnectionCreator
    {
        private readonly static string ConnectionString = "data source=EHSANVIVOBOOK\\EHSANSQLSERVER;initial catalog=OnlineTestDB;integrated security=true";
        private static SqlConnection? connection;
        public static SqlConnection Create()
        {
            if (connection == null)
                connection = new SqlConnection(ConnectionString);

            return connection;
        }
    }
}
