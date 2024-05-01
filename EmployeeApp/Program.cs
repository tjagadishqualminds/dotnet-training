namespace EmployeeApp
{
    enum EmployeeOptions
    {
        AddEmployee,
        DisplayEmployee,
        DisplayAllEmployee,
        UpdateEmployee,
        DeleteEmployee,
        
    }
    internal class Program
    {
        static void ReadUserOptions()
        {
            Operations operations = new Operations();
            while (true)
            {
            Console.WriteLine("Enter any options");
            Console.WriteLine("0. AddNewEmployee");
            Console.WriteLine("1. DisplayEmployee");
            Console.WriteLine("2. DisplayAllEmployee");
            Console.WriteLine("3. UpdateEmployee");
            Console.WriteLine("4. DeleteEmployee");
                //the user's selection and call the appropiate method
                int choice = int.Parse(Console.ReadLine());
            EmployeeOptions options = (EmployeeOptions)choice;
               

                switch(options)
                {
                    case EmployeeOptions.AddEmployee:
                        Console.WriteLine("Add Employee");
                        operations.AddEmployee();
                        break;
                    case EmployeeOptions.DisplayEmployee:
                        
                        Console.WriteLine("DisplayEmployee");
                        operations.DisplayEmployee();
                        break;
                    case EmployeeOptions.DisplayAllEmployee:
                        Console.WriteLine("DisplayAllEmployee");
                        operations.DisplayAllEmployee();
                            break;
                        case EmployeeOptions.UpdateEmployee:
                        Console.WriteLine("UpdateEmployee");
                        operations.UpdateEmployee();
                        break;
                    case EmployeeOptions.DeleteEmployee:
                        Console.WriteLine("DeleteEmployee");
                        operations.DeleteEmployee();
                        break;

                }

               
            }

        }
        //Start the application 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ReadUserOptions();

        }
    }
}
