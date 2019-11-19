using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfApp
{
    class Project
    {
        public int ProjectId { get; set; }
        public string ProName { get; set; }
        public string ProType { get; set; }
        public string ProPercenteComplete { get; set; }
        public string ProDeadline { get; set; }

        
        public Project()
        {
            //empty
        }

        public Project(string proname, string protype, string propercentecomplete, string prodeadline)
        {
            ProName = proname;
            ProType = protype;
            ProPercenteComplete = propercentecomplete;
            ProDeadline = prodeadline;
        }
    }
}
