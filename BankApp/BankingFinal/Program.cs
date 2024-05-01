namespace BankingFinal
{
    enum MenuOption
    {
        Deposit,
        Withdraw,
        transaction,
        NewAccount,
        FindAccount,
        PrintTransactionHistory,
        Print,
        Quit
    }
    internal class Program
    {

        //taking user inputs for doing deposit
        private static void DoDeposit(Bank toBank)
        {
            Account toAccount = FindAccount(toBank);
            if (toAccount == null) return;
            Console.WriteLine("Enter the Deposit amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            DepositTransaction transaction = new DepositTransaction(toAccount, amount);
            toBank.ExecuteTransaction(transaction);
            transaction.Print();
            
        }

        //taking user inputs for doing withdraw
        private static void DoWithdraw(Bank toBank)
        {
            Account toAccount = FindAccount(toBank);
            if (toAccount == null) return;
            Console.WriteLine("Enter the Withdrawl amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            WithdrawTransaction transaction = new WithdrawTransaction(toAccount, amount);
            toBank.ExecuteTransaction(transaction);
            transaction.Print();
        }
        //taking user inputs for doing transfer
        private static void Dotransaction(Bank toBank)
        {
            Console.WriteLine("\nEnter From account name");
            Account fromAccount = FindAccount(toBank);
            Console.WriteLine("\nEnter To account name");
            Account toAccount = FindAccount(toBank);
            if (toAccount == null || fromAccount == null) return;
            Console.WriteLine("\nTransfer");
            Console.WriteLine("\nEnter fromAccount Details");
            Console.WriteLine("\nEnter the transfer amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            TransferTransaction transaction = new TransferTransaction(fromAccount, toAccount, amount);
            toBank.ExecuteTransaction(transaction);
            transaction.Print();

        }


        //creating new account in bank
        private static void DoNewAccount(Bank bank)
        {
            Console.WriteLine("\nEnter Details for creating new account");
            Console.WriteLine("\nEnter AccountHolder New Name");
            string accountname = Console.ReadLine();
            Console.WriteLine("\nEnter AccountHolder New Balance");
            decimal accountbalance = decimal.Parse(Console.ReadLine());
            Account account = new Account(accountname, accountbalance);
            bank.AddAccount(account);
        }

        //this method for in bank finding account
        private static Account FindAccount(Bank fromBank)
        {
            Console.WriteLine("\nEnter account name:");
            string name = Console.ReadLine();
            Account result = fromBank.GetAccount(name);
            if (result == null)
            {
                Console.WriteLine($"\nNo account found with the name {name}");
            }
            else
            {
                Console.WriteLine($"\naccount found with the name {name}");
            }
            return result;

        }
        public static void TransactionHistory(Bank bank)
        {
            bank.PrintTranscationHistory();
        }

        static void Print(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null) return;
            Console.WriteLine(account.Name);
            Console.WriteLine(account.Balance);

        }
        static void ReadUserOption()
        {
            int userInput;

            Bank bank = new Bank();

            MenuOption menuOption;

            do
            {
                Console.WriteLine("Enter your option");
                Console.WriteLine("0.Deposit");
                Console.WriteLine("1.Withdraw");
                Console.WriteLine("2.Transaction");
                Console.WriteLine("3.NewAccount");
                Console.WriteLine("4.FindAccount");
                Console.WriteLine("5.PrintTransactionHistory");
                Console.WriteLine("6. Print");
                Console.WriteLine("7. Quit");
                userInput = Convert.ToInt32(Console.ReadLine());
                menuOption = (MenuOption)userInput;

                switch (menuOption)
                {
                    case MenuOption.Deposit:
                        DoDeposit(bank);
                        break;
                    case MenuOption.Withdraw:
                        DoWithdraw(bank);
                        break;
                    case MenuOption.transaction:
                        Dotransaction(bank);
                        break;
                    case MenuOption.NewAccount:
                        DoNewAccount(bank);
                        break;
                    case MenuOption.FindAccount:
                        FindAccount(bank);
                        break;
                    case MenuOption.PrintTransactionHistory:
                        TransactionHistory(bank);
                        break;
                    case MenuOption.Print:
                        Print(bank);
                        break;
                    case MenuOption.Quit:
                        Environment.Exit(0);
                        break;
                }
            } while (userInput >= 0 && userInput <= 6);
        }
        static void Main(string[] args)
        {
            //starts here
            ReadUserOption();
        }
    }
}
