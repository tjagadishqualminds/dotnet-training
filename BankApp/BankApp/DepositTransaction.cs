using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartFour
{
    internal class DepositTransaction
    {
        //fields
        private Account _account;
        private string _name;
        private Bank _bank;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;


        //prperties
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
        public decimal Amount
        {
            get { return _amount; }
        }
        public string Name
        {
            get { return _name; }
        }
       
    

        //method for deposit
        public DepositTransaction( Account toaccount,Bank bank ,decimal amount)
        {
            _bank = bank;
            _account = toaccount;
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
                throw new Exception("\nCannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;
            _account.Withdraw(_amount);
        }


        public void Print()
        {
            Console.WriteLine($"Deposit transaction: Amount: {_amount}, Executed: {_executed}, Success: {_success}, Reversed: {_reversed}");
        }
    }
}
