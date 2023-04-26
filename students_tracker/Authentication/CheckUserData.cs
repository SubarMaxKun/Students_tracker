using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace students_tracker.Authentication
{
    internal class CheckUserData
    {
        public bool Check(string username, string password)
        {
            string path = @"Data\users.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');
                    if (data[0] == username && data[1] == HashPassword.GetHash(password))
                    {
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не існує, зареєструйтеся спочатку.");
            }

            return false;
        }
    }
}
