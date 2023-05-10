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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            CheckUsername checkUsername = new();

            // Check if username is already taken
            if(!checkUsername.Check(UsernameTextBox.Text))
            {
                // Check if password is long enough
                if(PasswordPasswordBox.Password.Length>=8)
                {
                    // Write user's data to file
                    WriteUserData.Write(UsernameTextBox.Text, PasswordPasswordBox.Password);

                    // Menu window initialization
                    MenuWindow menuWindow = new(UsernameTextBox.Text);

                    // Open menu window and close this one
                    menuWindow.Show();
                    Window.GetWindow(this).Close();
                }
                else
                {
                    MessageBox.Show("Пароль повинен містити не менше 8 символів!");
                }
            }
            else
            {
                MessageBox.Show("Користувач вже існує!");
            }
        }
    }
}
