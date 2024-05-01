using System.Diagnostics;

namespace BankPartThree
{
    enum MenuOption
    {
        Deposit,
        Withdraw,
        transaction,
        Print,
        Quit
    }
    internal class Program
    {

        //takes inputs from the user for deposit
        private static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter the Deposit amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            DepositTransaction transaction = new DepositTransaction(account,amount);
            transaction.Execute();
            if(transaction.Success)
            {
                Console.WriteLine("Deposit successfully");
                transaction.Print();
            }
            else
            {
                Console.WriteLine("failed");
            }
        }
        // takes inputs from the user for  withdraw
        private static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter the Withdrawl amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            WithdrawTransaction transaction = new WithdrawTransaction(account,amount);
            transaction.Execute();
            if(transaction.Success)
            {
                Console.WriteLine("Withdraw succesfully");
                transaction.Print();
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }
            
        }
        //takes inputs form user for transfer method
        private static void Dotransaction()
        {
            Console.WriteLine("Transfer");
            Console.WriteLine("Enter fromAccount Details");
            Console.WriteLine("Enter Account Holder Name");
            string fromname = Console.ReadLine();
            Console.WriteLine("Enter Account Holder Balance");
            decimal frombalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter toAccount Details");
            Console.WriteLine("Enter Account Holder Name");
            string toname = Console.ReadLine();
            Console.WriteLine("Enter Account Holder Balance");
            decimal tobalance = decimal.Parse(Console.ReadLine());

            Account toAccount = new Account(toname,tobalance);
            Account fromAccount = new Account(fromname,frombalance);
            Console.WriteLine("Enter the transfer amount");
            decimal amount = decimal.Parse(Console.ReadLine());
            TransferTransaction transaction = new TransferTransaction(toAccount,fromAccount,amount);
            transaction.Execute();
            if(transaction.Success)
            {
                Console.WriteLine("Transfer successfull");
                transaction.Print();
            }
            else
            {
                Console.WriteLine("Transfer failed");
            }

        }
        static void Print(Account acount)
        {
            acount.Print();
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
                Console.WriteLine("2.Transaction");
                Console.WriteLine("3.Print");

              
              
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
                        case MenuOption.transaction:
                        Dotransaction();
                        break;
                    case MenuOption.Print:
                        Print(account);
                        break;
                
                    
                }
            } while (userInput >= 0 && userInput <= 4);
        }
        static void Main(string[] args)
        {
          //start here
            ReadUserOption();
        }
    }
}

