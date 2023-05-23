using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace students_tracker.Windows
{
    /// <summary>
    /// Interaction logic for ShowGroupsWindow.xaml
    /// </summary>
    public partial class ShowGroupsWindow : Window
    {
        public ShowGroupsWindow(string group)
        {
            InitializeComponent();

            // TODO: Upgrade realisation

            // Create and open connection to database
            MySqlConnection connection = new(ConfigurationManager.ConnectionStrings["students_tracker.Properties.Settings.students_trackerConnectionString"].ConnectionString);
            connection.Open();
            
            // Get all students from database
            string sql = "SELECT * FROM " + group;
            MySqlCommand cmd = new(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            // Put all students from database into datagrid
            DataGrid.ItemsSource = rdr;
        }
    }
}
