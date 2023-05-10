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
        private string username;

        public MenuWindow(string Username)
        {
            InitializeComponent();
            username = Username;
            GreetingsTextBlock.Text = "Із поверненням: " + username;

            // Check if user is admin
            if (username == "admin")
            {
                AddGroup.Visibility = Visibility.Visible;
                DeleteGroup.Visibility = Visibility.Visible;
            }
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
