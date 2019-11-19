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
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpfApp.Model.Repos;

namespace wpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext db = new AppDbContext();
        private EmployeeRepo EmpRepo = new EmployeeRepo();
        private DepartmentRepo DepRepo = new DepartmentRepo();
        private ProjectRepo ProRepo = new ProjectRepo();
        public MainWindow()
        {
            InitializeComponent();

            //ADDING EMPLOYEE TO DB
            //Employee employee = new Employee("Bartek", "Mały", 20, "Designer", "Warsaw", 123456789);
            //db.Employees.Add(employee);
            //db.SaveChanges();
            //EmpRepo.Insert(employee);

       


            //DELETING EMPLOYEE FROM DB
            //Employee employee = db.Employees.Find(1);
            //db.Employees.Remove(employee);
            //db.SaveChanges();

            //ADDING DEPARTMENTS TO DB
            // Department department = new Department("Ubisoft", "Domaniewska 39a", "Warszawa", 569875298);
            //db.Departments.Add(department);
            //db.SaveChanges();
            // DepRepo.Insert(department);

            //ADDING PROJECTS TO DB
            // Project project = new Project("Dusk", "Mobile", "60%", "January");
            //db.Projects.Add(project);
            //db.SaveChanges();
            //ProRepo.Insert(project);

        }

        private void btnEmp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmpWindow empWin = new EmpWindow();
            empWin.ShowDialog();
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnDep_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DepWindow depWin = new DepWindow();
            depWin.ShowDialog();

        }

        private void btnPro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProWindow proWin = new ProWindow();
            proWin.ShowDialog();
        }
    }
}
