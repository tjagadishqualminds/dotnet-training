using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    internal class SavingAccount : AccountAbs
    {
        int transactionCount = 0;
        public SavingAccount(string name, decimal balance, AccountTypes accounttype) : base(name, balance)
        {
            this.AccountType = accounttype;
        }

        public override void deposit(decimal amount)
        {
            if (amount > 50000)
            {
                Console.WriteLine("you cannot deposit above 50000");
            }
            else if (transactionCount >= 5)
            {
                Console.WriteLine("Transaction limit reached. Only five deposit are allowed.");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount.");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Deposit {amount:C}. Remaining balance: {Balance:C}");
                transactionCount++;
            }
        }

        public override void withdraw(decimal amount)
        {
            if(Balance-amount < 1000)
            {
                Console.WriteLine("Balance should be greater than 1000");
            }
        else if(transactionCount >= 5)
            {
                Console.WriteLine("Transaction limit reached. Only five withdrawals are allowed.");

            }
        else if( amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else if (amount > 50000)
            {
                Console.WriteLine("you cannot withdraw above 50000");
            }

            else
            {

                Balance -= amount;
                transactionCount++;
                Console.WriteLine($"Withdrawn {amount:C}. Remaining balance: {Balance:C}");
            }

                
            

        }


      
    }
}
