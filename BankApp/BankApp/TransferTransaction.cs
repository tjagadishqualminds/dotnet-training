using BankPartFour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankPartFour
{
    internal class TransferTransaction
    {
        //fields
        private  Account _toAccount;
        private Account _fromAccount;

        private Bank _toBank;
        private decimal _amount;

        private DepositTransaction _theDeposit;
        private WithdrawTransaction _theWithdraw;


   
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;

     

        //properties
        public Account FromAccount { get { return _fromAccount; } }
        public Account ToAccount { get { return _toAccount; } }
        public decimal Amount { get { return _amount; } }
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

        public TransferTransaction(Account fromAccount, Account toAccount, Bank toBank, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
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
                throw new Exception("\nCannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;
            
            _theDeposit.Rollback();
            _theWithdraw.Rollback();
        }


        //print the values
        public void Print()
        {
            Console.WriteLine("\nTransfer Transaction Details:");
            Console.WriteLine($"\nFrom Account: {_fromAccount.Name}");
            Console.WriteLine($"\nTo Account: {_toAccount.Name}");
            Console.WriteLine($"\nAmount: {_amount:C}");
            Console.WriteLine($"\nSuccess: {_success}");
            Console.WriteLine($"\nFromAccount balance : {_fromAccount.Balance}");
            Console.WriteLine($"\nToAccount balance:{_toAccount.Balance}");
        }
    }
    }


