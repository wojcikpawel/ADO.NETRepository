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
using wpfApp.Model.Repos;

namespace wpfApp
{
    /// <summary>
    /// Interaction logic for DepWindow.xaml
    /// </summary>
    public partial class DepWindow : Window
    {
        private DepartmentRepo DepRepo = new DepartmentRepo();
        public DepWindow()
        {
            InitializeComponent();
        }

        private void btnDepInsert_Click(object sender, RoutedEventArgs e)
        {
            //insert data to db
            //ADDING DEPARTMENT TO DB

            Department department = new Department(this.DepNameTextbox.Text, this.DepLocationTextbox.Text, this.DepCityTextbox.Text, this.DepPhoneTextbox.Text);
            
            DepRepo.Insert(department);
            MessageBox.Show("Department has been inserted!");

            this.Hide();
            DepListWindow depWin = new DepListWindow();
            depWin.ShowDialog();

        }

        private void btnDepBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWin = new MainWindow();
            mainWin.ShowDialog();
        }
    }
}
