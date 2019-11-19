using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfApp.Model.Repos
{
    class DepartmentRepo
    {
        private AppDbContext db = new AppDbContext();

        public DepartmentRepo()
        {
            //empty
        }

        public List<Department> GetAll()
        {
            return db.Departments.ToList();
        }

        public void Insert(Department department)
        {
           // Debug.WriteLine("Name=" + department.DepName);
           // Debug.WriteLine("Name=" + department.DepLocation);
          //  Debug.WriteLine("Name=" + department.DepCity);
           // Debug.WriteLine("Name=" + department.DepPhone);

            db.Departments.Add(department);
            db.SaveChanges();
        }

        public void Update(Department department)
        {
            db.Entry(department).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Department DepartmentId)
        {
            Department existing = db.Departments.Find(DepartmentId);
            db.Departments.Remove(existing);
            db.SaveChanges();
        }
    }
}
