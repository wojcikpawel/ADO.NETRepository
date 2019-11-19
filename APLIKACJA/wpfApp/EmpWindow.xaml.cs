using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EmpWindow.xaml
    /// </summary>
    public partial class EmpWindow : Window
    {
        private EmployeeRepo EmpRepo = new EmployeeRepo();
        public EmpWindow()
        {
            InitializeComponent();
        }

        private void btnEmpInsert_Click(object sender, RoutedEventArgs e)
        {
            //insert data to db
            //ADDING EMPLOYEE TO DB
            //Employee employee = new Employee("Pawel", "Wojcik", 21, "Programmer", "Cracow", 123456789);
            Employee employee = new Employee(this.EmpNameTextBox.Text, this.EmpLastNameTextBox.Text, this.EmpAgeTextBox.Text, this.EmpPostTextBox.Text, this.EmpCityTextBox.Text, this.EmpPhoneTextBox.Text);
            //db.Employees.Add(employee);
            //db.SaveChanges();
            EmpRepo.Insert(employee);
            MessageBox.Show("Employee has been inserted!");

            this.Hide();
            EmpListWindow empWin = new EmpListWindow();
            empWin.ShowDialog();
        }

        private void btnEmpBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();          
            MainWindow mainWin = new MainWindow();
            mainWin.ShowDialog();
        }
    }
}
