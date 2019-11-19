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
    /// Interaction logic for ProWindow.xaml
    /// </summary>
    public partial class ProWindow : Window
    {
        private ProjectRepo ProRepo = new ProjectRepo();
        public ProWindow()
        {
            InitializeComponent();
        }

        private void btnProInsert_Click(object sender, RoutedEventArgs e)
        {
            //insert data to db
            //ADDING PROJECT TO DB

            Project project = new Project(this.ProNameTextBox.Text,this.ProTypeTextBox.Text, this.ProPercenteTextBox.Text,this.ProDeadlineTextBox.Text);
            //db.Employees.Add(employee);
            //db.SaveChanges();

            ProRepo.Insert(project);
            MessageBox.Show("Project has been inserted!");

            this.Hide();
            ProListWindow proWin = new ProListWindow();
            proWin.ShowDialog();
        }

        private void btnProBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWin = new MainWindow();
            mainWin.ShowDialog();
        }
    }
}
