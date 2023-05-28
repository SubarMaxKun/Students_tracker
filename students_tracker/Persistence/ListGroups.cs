using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace students_tracker.Persistence
{
    internal class ListGroups
    {
        //list groups
        public static List<string> List()
        {
            List<string> groups = new();
           
            // Create and open connection to database
            DatabaseConnection databaseConnection = new();

            // Get all groups from database and put them into list
            MySqlDataReader reader = (MySqlDataReader)databaseConnection.Query("SHOW TABLES");
            while (reader.Read())
            {
                groups.Add(reader.GetString(0));
            }

            // Close connection to database
            databaseConnection.Disconnect();

            return groups;
        }
    }
}
