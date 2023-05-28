using students_tracker.Persistence;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for DeleteGroupPage.xaml
    /// </summary>
    public partial class DeleteGroupPage : Page
    {
        public DeleteGroupPage()
        {
            InitializeComponent();

            GroupComboBox.ItemsSource = Persistence.ListGroups.List();
        }

        private void DeleteGroupButton_Click(object sender, RoutedEventArgs e)
        {
            DatabaseConnection databaseConnection = new();
            databaseConnection.Query("DROP TABLE IF EXISTS " + GroupComboBox.Text);
            databaseConnection.Disconnect();
        }
    }
}
