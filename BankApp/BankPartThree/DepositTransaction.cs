using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartThree
{
    internal class DepositTransaction
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

        //constructor
        public DepositTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        //method for exection
        public void Execute()
        {
            if (_executed)
            {
                throw new Exception("Cannot execute this transaction as it exe");
            }
            _executed = true;
            _success = _account.Deposit(_amount);

        }
        //rollback
        public void Rollback()
        {
            if (!_executed || _reversed)
            {
                throw new Exception("Cannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;
            _account.Deposit(_amount);
        }

        //after deposit it prints
        public void Print()
        {
            Console.WriteLine($"Deposit transaction: Amount: {_amount}, Executed: {_executed}, Success: {_success}, Reversed: {_reversed}");
        }
    }
}
