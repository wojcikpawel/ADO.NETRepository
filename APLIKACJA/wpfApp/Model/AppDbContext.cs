using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfApp
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
