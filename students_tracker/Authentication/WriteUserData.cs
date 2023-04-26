using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_tracker.Authentication
{
    static class WriteUserData
    {
        public static void Write(string username, string password)
        {
            string path = @"Data\users.txt";

            if (File.Exists(path))
            {
                // Write user data in a new line to a text document
                File.AppendAllText(path, Environment.NewLine + username + "|" + HashPassword.GetHash(password));
            }
            else
            {
                // Create file, close it and then write data
                var a = File.Create(path);
                a.Close();
                File.AppendAllText(path, username + "|" + HashPassword.GetHash(password));
            }
        }
    }
}
