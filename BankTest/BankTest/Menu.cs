using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    enum options
    {
        NewAccount,
        withdraw,
        deposit
    }
    internal class Menu
    {
        Operations operations =new Operations();
        public void ReadUserOptions()
        {
            while (true)
            {

            Console.WriteLine("0. Create New Account\n1. Withdraw\n2. Deposit");
           int choice = int.Parse(Console.ReadLine());
            
                Enum @enum = (options)choice;

            switch(@enum)
            {
                case options.NewAccount:
                    Console.WriteLine("\nNew Account");
                    Console.WriteLine("Enter New Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Initial Balance");
                    decimal balance = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Choose a Type of Account");
                    Console.WriteLine(" \n0. SavingsAccount\n1.FixedAccount");
                    int accountchoice = int.Parse( Console.ReadLine());
                    if (accountchoice == 0)
                    {
                        Console.WriteLine("\nCreating Saving Account");
                        AccountTypes accountType = (AccountTypes)0;
                        SavingAccount accountef = new SavingAccount(name,balance, accountType);
                        operations.CreateAccount(accountef);
                        Console.WriteLine("\nSaving Account Created Successfully");
                      
                    }
                    else if(accountchoice == 1)
                    {
                        Console.WriteLine("\nCreating Fixed Account");
                        AccountTypes accountType = (AccountTypes)1;
                        FixedAccount fixedaccount = new FixedAccount(name,balance, accountType);
                        operations.CreateAccount(fixedaccount);
                        Console.WriteLine("\nFixed Account Created Successfully");

                    }
                    break;

                    case options.withdraw:
                    Console.WriteLine("\nEnter a Name ");
                    string findName = Console.ReadLine();
                   AccountAbs account= operations.GetAccount(findName);
                    if (account != null)
                    {
                        Console.WriteLine("\nAccount found");
                        Console.WriteLine("\nEnter a Amount for Withdrawl");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        account.withdraw(withdrawAmount);
                       

                    }
                    else
                    {
                        Console.WriteLine("\naccount not found");
                    }

                    break;
                    case options.deposit:
                    Console.WriteLine("\nEnter a Name ");
                    string finddpName = Console.ReadLine();
                    AccountAbs accountdp = operations.GetAccount(finddpName);
                    if (accountdp != null)
                    {
                        Console.WriteLine("Account found");
                        Console.WriteLine("\nEnter a Amount Deposit");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        accountdp.deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("\naccount not found");
                    }
                    break;
            }
            }
          

        }

    }
}
