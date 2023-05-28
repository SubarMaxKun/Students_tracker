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
    /// Interaction logic for CreateGroupPage.xaml
    /// </summary>
    public partial class CreateGroupPage : Page
    {
        public CreateGroupPage()
        {
            InitializeComponent();
        }

        private void CreateGroupButton_Click(object sender, RoutedEventArgs e)
        {
            CreateGroup createGroup = new();
            createGroup.Create(GroupNameTextBox.Text);
        }
    }
}
