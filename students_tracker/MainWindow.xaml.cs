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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace students_tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                DatabaseConnection databaseConnection = new();
                databaseConnection.Connect();
                databaseConnection.Disconnect();
            }
            catch (Exception)
            {
                MessageBox.Show("Неможливо встановити з'єднання із базою даних!");
                Close();
            }

            // TODO: Remove this after testing
            new MenuWindow("admin").Show();
            Close();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = new Pages.LoginPage();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = new Pages.RegisterPage();
        }
    }
}
