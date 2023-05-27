using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_tracker.Persistence
{
    class DatabaseConnection
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["students_tracker.Properties.Settings.students_trackerConnectionString"].ConnectionString;

        public void Connect()
        {
            MySqlConnection connection = new(connectionString);
            connection.Open();
        }

        public object Query(string sql)
        {
            MySqlConnection connection = new(connectionString);
            connection.Open();
            MySqlCommand command = new(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void Disconnect()
        {
            MySqlConnection connection = new(connectionString);
            connection.Close();
        }
    }
}