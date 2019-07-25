using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebCarAPI.Repository.Utilities
{
    public static class ConnectionFactory
    {
         public static string _sqlConnection =
            "server=23.98.153.101;database=DeveloperDB11;user=developer;password=dev123DEV123";

        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_sqlConnection);
            conn.Open();
            return conn;

        }

    }
}
