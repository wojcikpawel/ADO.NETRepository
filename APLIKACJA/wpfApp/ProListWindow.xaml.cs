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

namespace wpfApp
{
    /// <summary>
    /// Interaction logic for ProListWindow.xaml
    /// </summary>
    public partial class ProListWindow : Window
    {
        public ProListWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            wpfApp.pawelDBDataSet pawelDBDataSet = ((wpfApp.pawelDBDataSet)(this.FindResource("pawelDBDataSet")));
            // Load data into the table Projects. You can modify this code as needed.
            wpfApp.pawelDBDataSetTableAdapters.ProjectsTableAdapter pawelDBDataSetProjectsTableAdapter = new wpfApp.pawelDBDataSetTableAdapters.ProjectsTableAdapter();
            pawelDBDataSetProjectsTableAdapter.Fill(pawelDBDataSet.Projects);
            System.Windows.Data.CollectionViewSource projectsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("projectsViewSource")));
            projectsViewSource.View.MoveCurrentToFirst();
        }

        private void btnExitProList_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBackProList_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProWindow proWin = new ProWindow();
            proWin.ShowDialog();
        }
    }
}
