using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace wpfApp
{
    public class Employee
    {
       // private string text1;
      //  private string text2;
      //  private TextBox empAgeTextBox;
     //   private string text3;
     //   private string text4;
     //   private int lineCount;
       // private TextBox empPhoneTextBox;

        public int EmployeeId { get; set; }

        public string EmpName { get; set; }
        
        public string EmpLastName { get; set; }
        
        public string EmpAge { get; set; }
        public string EmpPost { get; set; } 

        public string EmpCity { get; set; }

        public string EmpPhone { get; set;  }


        
        public  Employee()
        {
            //empty
        }

        //emid?
        public Employee(string empname, string emplastname, string empage, string emppost, string empcity, string empphone)
        {
            EmpName = empname;
            EmpLastName = emplastname;
            EmpAge = empage;
            EmpPost = emppost;
            EmpCity = empcity;
            EmpPhone = empphone;
        }

      
    }
}
