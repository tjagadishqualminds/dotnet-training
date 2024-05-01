using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartTwo
{
    internal class Account
    {
        private decimal _balance;
        private readonly string _name;

        public Account(string name, decimal balance)
        {

            _name = name;
            _balance = balance;

        }
        public Account()
        {

        }

        public void Print()
        {
            Console.WriteLine( $"Name: {_name}, Balance: {_balance}");
        }
        public bool Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw > 0)
            {
                if(_balance >=amountToWithdraw)
                {

                    return true;
                }

            }
            return false;
            

        }
        public bool Deposit(decimal amountToDeposit)
        {
           if(amountToDeposit > 0)
            {
                _balance += amountToDeposit;
                return true;
            }
           return false;
        }
    }
}
