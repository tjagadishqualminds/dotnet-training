namespace BankPartTwo
{
    enum MenuOption
    {
        Deposit,
        Withdraw,
        Print,
        Quit
    }
    internal class Program
    {
        
        private static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter the Deposit amount");
             decimal amount = decimal.Parse(Console.ReadLine());
            account.Deposit(amount);    
        }

        private static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter the Withdrawl amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        private static void DoPrint(Account account)
        {
            Console.WriteLine("Account Details");
            account.Print();
        }
        static void ReadUserOption()
        {
            int userInput;
            Account account = new Account("jagadish", 1000);
            MenuOption menuOption;

            do
            {
                Console.WriteLine("Enter your option");
                Console.WriteLine("0.Deposit");
                Console.WriteLine("1.Withdraw");
                Console.WriteLine("2.Print");
                userInput = Convert.ToInt32(Console.ReadLine());
                menuOption = (MenuOption)userInput;

                switch (menuOption)
                {
                    case MenuOption.Deposit:
                        DoDeposit(account);
                        break;
                    case MenuOption.Withdraw:
                        DoWithdraw(account);
                        break;
                    case MenuOption.Print:
                        DoPrint(account);
                        break;
                }
            } while (userInput >=0 && userInput<=2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! jagaish");
            ReadUserOption();
        }
    }
}
