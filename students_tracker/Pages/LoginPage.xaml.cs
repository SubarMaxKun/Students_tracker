using students_tracker.Authentication;
using students_tracker.Windows;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            CheckUserData checkUserData = new();

            // Check if user's data is correct
            if (checkUserData.Check(UsernameTextBox.Text, PasswordPasswordBox.Password))
            {
                // Menu window initialization
                MenuWindow menuWindow = new(UsernameTextBox.Text);

                // Open menu window and close this one
                menuWindow.Show();
                Window.GetWindow(this).Close();
            }
            else
            {
                // Needs future upgrade with functionality
                MessageBox.Show("Wrong username or password.");
            }
        }
    }
}
