using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_tracker.Persistence
{
    internal class CreateGroup
    {
        public void Create(string GroupName)
        {
            // Method intentionally left empty.
            DatabaseConnection databaseConnection = new();
            databaseConnection.Query("CREATE TABLE IF NOT EXISTS " + GroupName + " (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), surname VARCHAR(255), subject VARCHAR(255), mark INT) ENGINE=INNODB");
            databaseConnection.Disconnect();
        }
    }
}
