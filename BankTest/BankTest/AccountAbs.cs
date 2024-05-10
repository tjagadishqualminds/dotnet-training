using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    public enum AccountTypes
    {
        SavingsAccount,
        FixedAccount
    }
    abstract class AccountAbs:IAccount
    {
        protected AccountAbs(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name {  get; set; }
        public decimal Balance {  get; set; }

        public AccountTypes AccountType {  get; set; }

        public abstract void withdraw(decimal amount);

        public abstract void deposit(decimal amount);
     

  
    }
}
