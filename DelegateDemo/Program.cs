namespace DelegateDemo
{
    internal class Program
    {
        public delegate void EmployeeDepartmentDelegate(int id,string  name);
        public delegate void EmployeeSalary(float salary, float pf);
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            EmployeeDepartmentDelegate employeeDepartment = new EmployeeDepartmentDelegate(employee.EmployeeDepartment);
            employeeDepartment.Invoke(12, "it");
            EmployeeSalary empsalary = new EmployeeSalary(employee.EmployeeSalaryOneDetail);
             EmployeeSalary empTwosalary = new EmployeeSalary(employee.EmployeeSalaryTwoDetail);
            EmployeeSalary allemp;
            //multicast
            allemp = empsalary + empTwosalary;
            allemp.Invoke(120, 20);

            empsalary.Invoke(123, 23);
            empTwosalary.Invoke(120, 20);
            
        
            Console.ReadLine();
        }
    }
}
