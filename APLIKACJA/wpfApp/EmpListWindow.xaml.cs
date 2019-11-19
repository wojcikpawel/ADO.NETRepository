using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using wpfApp.Model.Repos;

namespace wpfApp
{
    /// <summary>
    /// Interaction logic for EmpListWindow.xaml
    /// </summary>
    public partial class EmpListWindow : Window
    {
        private EmployeeRepo empRepo = new EmployeeRepo();
        public EmpListWindow()
        {
            InitializeComponent();
        }


       

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            wpfApp.pawelDBDataSet pawelDBDataSet = ((wpfApp.pawelDBDataSet)(this.FindResource("pawelDBDataSet")));
            // Load data into the table Employees. You can modify this code as needed.
            wpfApp.pawelDBDataSetTableAdapters.EmployeesTableAdapter pawelDBDataSetEmployeesTableAdapter = new wpfApp.pawelDBDataSetTableAdapters.EmployeesTableAdapter();
            pawelDBDataSetEmployeesTableAdapter.Fill(pawelDBDataSet.Employees);
            System.Windows.Data.CollectionViewSource employeesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeesViewSource")));
            employeesViewSource.View.MoveCurrentToFirst();



        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void btnEmpDelete_PreviewKeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void btnEmpUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExitEmpList_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBackEmpList_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmpWindow empWin = new EmpWindow();
            empWin.ShowDialog();
        }
    }
}