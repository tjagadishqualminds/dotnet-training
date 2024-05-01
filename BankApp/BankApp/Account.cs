using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartFour
{
    internal class Account
    {
        //fields
        private decimal _balance;
        private readonly string _name;

        //Constructor
        public Account(string name, decimal balance)
        {

            _name = name;
            _balance = balance;

        }
        //properties
        public string Name { get { return _name; } }
        public decimal Balance { get { return _balance; } }

      //method for withdraw
        public bool Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > 0)
            {
                if (_balance >= amountToWithdraw)
                {
                    _balance -= amountToWithdraw;
                    return true;
                }

            }
            return false;


        }
        //method for deposit
        public bool Deposit(decimal amountToDeposit)
        {
            if (amountToDeposit > 0)
            {
                _balance += amountToDeposit;
                return true;
            }
            return false;
        }
    }
}
