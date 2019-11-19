using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfApp.Model.Repos
{
    class EmployeeRepo 
    {
        private AppDbContext db = new AppDbContext();

        public EmployeeRepo()
        {
            //empty
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public void Insert(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void Update(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            Employee existing = db.Employees.Find(employee);
            db.Employees.Remove(existing);
            db.SaveChanges();
        }

        
    }
}
