using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartThree
{
    internal class TransferTransaction
    {
        //fields
        private Account _toAccount;
       

        private Account _fromAccount;
    
        private decimal _amount;

        private DepositTransaction _theDeposit;
        private WithdrawTransaction _theWithdraw;

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
        public TransferTransaction(Account ToAccount,Account fromAccount ,decimal amount)
        {
           _toAccount = ToAccount;
            _fromAccount = fromAccount;
            _amount = amount;
        }


        //execution of transfer 
        public void Execute()
        {
            if (_fromAccount.Withdraw(_amount))
            {
                _toAccount.Deposit(_amount);
                _success = true;
            }
            else
            {
                _success = false;
            }

            _executed = true;
        }


        //rollback for transfer
        public void Rollback()
        {
            if (!_executed || _reversed)
            {
                throw new Exception("Cannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;
         
            _theDeposit.Rollback();
            _theWithdraw.Rollback();
        }

        public void Print()
        {
            Console.WriteLine("Transfer Transaction Details:");
            Console.WriteLine($"From Account: {_fromAccount.Name}");
            Console.WriteLine($"To Account: {_toAccount.Name}");
            Console.WriteLine($"Amount: {_amount:C}");
            Console.WriteLine($"Success: {_success}");
            Console.WriteLine($"FromAccount balance : {_fromAccount.Balance}");
            Console.WriteLine($"ToAccount balance:{_toAccount.Balance}");
        }
    }
}
