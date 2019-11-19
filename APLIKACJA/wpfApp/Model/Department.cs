using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfApp
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepName { get; set; }

        public string DepLocation { get; set; }

        public string DepCity { get; set; }

        public string DepPhone { get; set; }

       
        public Department()
        {
            //empty
        }

        public Department(string depname, string deplocation, string depcity, string depphone)
        {
            DepName = depname;
            DepLocation = deplocation;
            DepCity = depcity;
            DepPhone = depphone;

        }
    }
}
