using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class EmployeeOperations
    {
        //Declare a list of EMP
        ArrayList emp = new ArrayList();
        
        //Add a new employee to the list
        public void AddEmp(EmployeeModal employee)
        {
            emp.Add(employee);
        }

        //Return a single employee based on its id
        public EmployeeModal DisplaySingleEmployee(int id)
        {
          foreach (EmployeeModal obj in emp)
            {
                if ( id ==obj.EmpId)
                {
                    return obj;
                }
                
            }
          return null;

        }

        //return a  entire list of employee
        public ArrayList DisplayAllEmployee()
        {
            return emp;
        }

        //Remove a Employee from the list based on its id
        public bool DeleteEmployee(int delid)
        {
            for(int i = emp.Count - 1; i >= 0; i--)
            {
                EmployeeModal obj = (EmployeeModal)emp[i];
                if(obj.EmpId == delid)
                {
                    emp.RemoveAt(i);
                    return true;
                    
                }
              
            }
            return false;

        }

        //Update a Employee from the list base on its id
        public void UpdateEmployee(int upid,EmployeeModal newemployee )
        {
         
            for(int i =0; i < emp.Count; i++)
            {
                EmployeeModal obj= (EmployeeModal)emp[i];
                if(obj.EmpId == upid)
                {
                    emp[i] = newemployee;
                    break;
                }
            }
        }
    }
}
