using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    internal class FixedAccount : AccountAbs
    {
        private bool hasWithdrawn = false;
        public FixedAccount(string name, decimal balance, AccountTypes accounttype) : base(name, balance)
        {
            this.AccountType = accounttype;
        }

        public override void deposit(decimal amount)
        {
            if(amount >0) { 
            Balance += amount;
                Console.WriteLine($"Deposit {amount:C}. Remaining balance: {Balance:C}");

            }

        }

        public override void withdraw(decimal amount)
        {
          
            if(!hasWithdrawn && amount >0 && amount <=Balance)
            {
                Balance -= amount;
                hasWithdrawn=true;
                Console.WriteLine($"Withdrawn {amount:C}. Remaining balance: {Balance:C}");


            }

            else
            {
                if (hasWithdrawn)
                {
                    Console.WriteLine("Withdrawal limit reached. Only one withdrawal is allowed.");
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds for withdrawal.");
                }
            }

        }
    }
}
