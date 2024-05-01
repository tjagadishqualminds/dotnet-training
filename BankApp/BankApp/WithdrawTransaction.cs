using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartFour
{
    internal class WithdrawTransaction
    {
        //fields
        private Account _account;
        private Bank _bank;
        private string _name;

        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;

        //properties
        public bool Success
        {
            get { return _success; }
        }

        public bool Reversed
        {
            get { return _reversed; }
        }

        public bool Executed
        {
            get { return _executed; }
        }
    

    
     
        //constructor for withdrawtransaction
        public WithdrawTransaction(Account account, Bank bank, decimal amount)
        {
            _bank = bank;
            _amount = amount;
            _account = account;
        }

      
        //method for execute 
        public void Execute()
        {
            if (_executed)
            {
                throw new Exception("\nCannot execute this transaction as it exe");
            }
            _executed = true;
            _success = _account.Withdraw(_amount);

        }

        //method for rollback
        public void Rollback()
        {
            if (!_executed || _reversed)
            {
                throw new Exception("\nCannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;
            _account.Deposit(_amount);
        }

        //method fo print withdraw amount
        public void Print()
        {
            Console.WriteLine($"Withdrawal transaction: Amount: {_amount}, Executed: {_executed}, Success: {_success}, Reversed: {_reversed}");
        }
    }
}
