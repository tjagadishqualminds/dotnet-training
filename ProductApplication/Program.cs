using System.Security.Cryptography.X509Certificates;

namespace ProductApplication
{
    enum MenuOptions
    {
        AddProduct,
        ShowAllProducts,
        ShowSingleProduct,
        UpdateProduct,
        DeleteProduct,
        Quit
    }
    internal class Program
    {
        static void ReadUserOptions()
        {
          
            Operations operations = new Operations();
            while(true)
            {
                Console.WriteLine("Enter Your Option");
                Console.WriteLine("0: AddProduct");
                Console.WriteLine("1: ShowAllProduct");
                Console.WriteLine("2: ShowSingleProduct");
                Console.WriteLine("3: UpdateProduct");
                Console.WriteLine("4: DeleteProduct");
                Console.WriteLine("5: Quit");
                //the user's selection and call the appropiate method
                int choice = int.Parse(Console.ReadLine());

                MenuOptions menuOptions = (MenuOptions)choice;

            
                switch (menuOptions)
                {                  
                    case MenuOptions.AddProduct:
                        operations.AddProduct();
                
                        break;
                        case MenuOptions.ShowAllProducts:
                        operations.ShowAllProducts();
                        break;
                        case MenuOptions.ShowSingleProduct:
                           operations.ShowSingleProduct();
                        break;
                        case MenuOptions.DeleteProduct:
                         operations.DeleteProduct();
                        break;
                        case MenuOptions.UpdateProduct:
                        operations.UpdateProduct();
                        break;
                        case MenuOptions.Quit:
                        Environment.Exit(0);
                        break;
            }

                }

          
                  
        }
        //Start the application 
        static void Main(string[] args)
        {
         
            ReadUserOptions();
        }
    }
}
