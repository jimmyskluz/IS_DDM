using System;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DBConnector
    {
        private SqlConnection connection;
        private static readonly DBConnector instance = new DBConnector()
        {
            connection = new SqlConnection(new SqlConnectionStringBuilder()
            {
                DataSource = @"dbsys.cs.vsb.cz\STUDENT",
                UserID = "klu0096",
                Password = "xxxxxxx",
                InitialCatalog = "klu0096"
            }.ConnectionString)
        };

        private DBConnector() { }

        public static DBConnector GetInstance()
        {
            return instance;
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
            }
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
