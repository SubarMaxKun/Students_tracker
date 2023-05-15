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
using System.Windows.Shapes;

namespace students_tracker.Windows
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        public MenuWindow(string Username)
        {
            InitializeComponent();
            GreetingsTextBlock.Text = "Із поверненням: " + Username;

            // Check if user is admin
            if (Username == "admin")
            {
                AddGroup.Visibility = Visibility.Visible;
                DeleteGroup.Visibility = Visibility.Visible;
            }
        }

        private void ShowGroups_Click(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
            ContentFrame.Content = new Pages.ShowGroupsPage();
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
        }

        private void DeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
        }

    }
}
