using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfApp.Model.Repos
{
    class ProjectRepo
    {
        private AppDbContext db = new AppDbContext();

        public ProjectRepo()
        {
            //empty
        }

        public List<Project> GetAll()
        {
            return db.Projects.ToList();
        }

        public void Insert(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
        }

        public void Update(Project project)
        {
            db.Entry(project).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Project ProjectId)
        {
            Project existing = db.Projects.Find(ProjectId);
            db.Projects.Remove(existing);
            db.SaveChanges();
        }
    }
}
