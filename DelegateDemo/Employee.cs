using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Employee
    {


        public void EmployeeDepartment(int deptid ,string deptname)
        {
            Console.WriteLine($"Departmentid :{deptid},DepartmentName:{deptname}");
        }
        public void EmployeeSalaryOneDetail(float basesalary,float pf)
        {
            Console.WriteLine($"Employee salaryone : {basesalary},Employeeone Pf: {pf}  EmployeeOneTotal salary {basesalary-pf}");
        }
        public void EmployeeSalaryTwoDetail(float basesalary, float pf)
        {
            Console.WriteLine($"EmployeeTwo salary : {basesalary},EmployeeTwo Pf: {pf}  EmployeeTwoTotal salary {basesalary - pf}");
        }
    }
}
