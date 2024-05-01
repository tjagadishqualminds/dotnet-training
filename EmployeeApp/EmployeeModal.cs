using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class EmployeeModal
    {
        //declaration of fields
        private string empname;
        private int empid;
        private decimal salary;

        //properties
        public EmployeeModal() { }
        public string EmpName { get { return empname; } set { empname = value; } }
        public int EmpId { get { return empid; } set { empid = value; } }

        public decimal Salary { get { return salary; } set { salary = value; } }
    }
}
