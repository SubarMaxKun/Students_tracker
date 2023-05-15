using MySql.Data.MySqlClient;
using students_tracker.Persistence;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace students_tracker.Pages
{
    /// <summary>
    /// Interaction logic for ShowGroupsPage.xaml
    /// </summary>
    public partial class ShowGroupsPage : Page
    {
        public ShowGroupsPage()
        {
            InitializeComponent();

            MySqlConnection connection = new(ConfigurationManager.ConnectionStrings["students_tracker.Properties.Settings.students_trackerConnectionString"].ConnectionString);
            connection.Open();

            string sql = "SHOW TABLES";
            string result = "";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Button button = new Button();
                {
                    button.Content = rdr.GetString(0);
                    button.Click += new RoutedEventHandler(ShowGroup_Click);
                }

                ContententStackPanel.Children.Add(button);
            }
        }

        private void ShowGroup_Click(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
        }
    }
}
