using MySql.Data.MySqlClient;
using students_tracker.Persistence;
using students_tracker.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
            
            // Create and open connection to database
            MySqlConnection connection = new(ConfigurationManager.ConnectionStrings["students_tracker.Properties.Settings.students_trackerConnectionString"].ConnectionString);
            connection.Open();

            // Get all tables from database
            string sql = "SHOW TABLES";
            MySqlCommand cmd = new(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            // Shitty realization of showing all groups as buttons, but
            // atleast it works
            while (rdr.Read())
            {
                Button button = new();
                {
                    button.Content = rdr.GetString(0);
                    button.Width = 100;
                    button.Height = 100;
                    button.Margin = new Thickness(10);
                    button.Click += new RoutedEventHandler(ShowGroup_Click);
                }

                ContentWrapPanel.Children.Add(button);
            }

            // Close connection to database
            connection.Close();
        }

        private void ShowGroup_Click(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
            var group = ((Button)sender).Content.ToString();
            ShowGroupsWindow showGroupsWindow = new(group);
            showGroupsWindow.ShowDialog();
        }
    }
}
