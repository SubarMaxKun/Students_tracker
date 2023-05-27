using MySql.Data.MySqlClient;
using students_tracker.Persistence;
using students_tracker.Windows;
using System;
using System.Collections;
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
            List<string> groups = ListGroups.listGroups();

            // Show all groups and add buttons
            for (int i = 0; i < groups.Count; i++)
            {
                Button button = CreateButton(groups, i);
                ContentWrapPanel.Children.Add(button);
            }
        }

        private Button CreateButton(List<string> groups, int i)
        {
            Button button = new();
            {
                button.Content = groups[i];
                button.Width = 100;
                button.Height = 100;
                button.Margin = new Thickness(10);
                button.Click += new RoutedEventHandler(ShowGroup_Click);
            }

            return button;
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
