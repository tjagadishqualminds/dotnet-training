using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class Operations
    {
        //Create an instance of ProductModal
        EmployeeModal employee = new EmployeeModal();

        //Create an instance of EmployeeOperations
        EmployeeOperations operations = new EmployeeOperations();

        //Add new Product to the list

        public void AddEmployee()
        {
            Console.WriteLine("Enter Employee Name");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee ID");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            decimal salary = decimal.Parse(Console.ReadLine());
            //create a new EmployeeModal object and set its properties

            EmployeeModal employee = new EmployeeModal();
            employee.EmpId = empid;
            employee.EmpName = empname;
            employee.Salary = salary;
            //add the EmployeeModat object to the List

            operations.AddEmp(employee);


        }

        //Display a Employee in the list based on id

        public void DisplayEmployee() {

            Console.WriteLine("Enter a id Display Employee");
            int disid = int.Parse(Console.ReadLine());
           
            EmployeeModal employee = operations.DisplaySingleEmployee(disid) ;
            if(employee != null)
            {
                Console.WriteLine($"EmployeeName:{employee.EmpName},Employeeid :{employee.EmpId},EmployeeSalary:{employee.Salary}");
            }
        }
        //Display all Employees in the list
        public void DisplayAllEmployee()

        {
          ArrayList arr = operations.DisplayAllEmployee();
            foreach( EmployeeModal employee in arr )
            {
                Console.WriteLine($"EmployeeName :{employee.EmpName},EmployeeId:{employee.EmpId},EmployeeSalary:{employee.Salary}");
            }

          

        }
        //Delete a Employee from the list based on its id
        public bool DeleteEmployee() {
            Console.WriteLine("Enter id for deleting employee");
            int delid = int.Parse(Console.ReadLine());
         
            if (operations.DeleteEmployee(delid))
            {
                Console.WriteLine($"Employee deleted with id {delid}");
                return true;
            }
            else {
                Console.WriteLine("Employee id not found");
                return false;
            } 
        }
        //Update a Employee details from the list based on its id
        public void UpdateEmployee() {
            Console.WriteLine("Enter employeee id for update");
            int upid =int.Parse(Console.ReadLine());
            var str = operations.DisplaySingleEmployee(upid);
            if(str != null)
            {
                Console.WriteLine("Enter new Employee name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new Employee salary");
                decimal salary = decimal.Parse(Console.ReadLine());
                employee.EmpName = name;
                employee.Salary= salary;
                employee.EmpId =upid;
                operations.UpdateEmployee(upid, employee);
            }
        }

    }
}
