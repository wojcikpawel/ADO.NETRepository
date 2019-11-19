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
    /// Interaction logic for DepListWindow.xaml
    /// </summary>
    public partial class DepListWindow : Window
    {
        public DepListWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            wpfApp.pawelDBDataSet pawelDBDataSet = ((wpfApp.pawelDBDataSet)(this.FindResource("pawelDBDataSet")));
            // Load data into the table Departments. You can modify this code as needed.
            wpfApp.pawelDBDataSetTableAdapters.DepartmentsTableAdapter pawelDBDataSetDepartmentsTableAdapter = new wpfApp.pawelDBDataSetTableAdapters.DepartmentsTableAdapter();
            pawelDBDataSetDepartmentsTableAdapter.Fill(pawelDBDataSet.Departments);
            System.Windows.Data.CollectionViewSource departmentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("departmentsViewSource")));
            departmentsViewSource.View.MoveCurrentToFirst();
        }

        private void btnExitDepList_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBackDepList_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DepWindow depWin = new DepWindow();
            depWin.ShowDialog();
        }
    }
}
