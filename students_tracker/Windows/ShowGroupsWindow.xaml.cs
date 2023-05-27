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
            // Create connection to database
            DatabaseConnection databaseConnection = new();

            // Put all students from database into datagrid
            DataGrid.ItemsSource = (System.Collections.IEnumerable)databaseConnection.Query("SELECT * FROM " + group);
            databaseConnection.Disconnect();
        }
    }
}
