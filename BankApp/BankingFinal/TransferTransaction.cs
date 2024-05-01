using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingFinal
{
 

    internal class TransferTransaction : Transaction
    {
        //fields
        bool _executed = false;
        bool _reversed = false;
        bool _success = false;


        Account _toAccount;
        Account _fromAccount;


        //properties
        public bool Executed { get { return _executed; } private set { _executed = value; } }
        public override bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } private set { _reversed = value; } }



        //constructor
        public TransferTransaction(Account fromaccount,Account toaccount, decimal amount) : base(amount)
        {
            _fromAccount = fromaccount;
            _toAccount = toaccount;
        }

        //methods
        public override void Execute()
        {
            base.Execute();
            if (_executed)
            {
                throw new Exception("Cannot execute this transaction as it exe");
            }
            _executed = true;
            if (_fromAccount.Withdraw(_amount))
            {
                _toAccount.Deposit(_amount);
                _success = true;
            }
            else
            {
                _success = false;
            }

            
        }


        public override void Print()
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
