using BankPart31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPart31
{
    internal class WithdrawTransaction
    {
        //fields
        private Account _account;
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
        //construcotr 
        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }
        // method for execution
        public void Execute()
        {
            if (_executed)
            {
                throw new Exception("Cannot execute this transaction as it exe");
            }
            _executed = true;
            _success = _account.Withdraw(_amount);

        }
        //method for rollback
        public void Rollback()
        {
            if (!_executed || _reversed)
            {
                throw new Exception("Cannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;
            _account.Deposit(_amount);
        }
        //print method for withdraw transaction
        public void Print()
        {
            Console.WriteLine($"Withdrawal transaction: Amount: {_amount}, Executed: {_executed}, Success: {_success}, Reversed: {_reversed}");
        }
    }
}

