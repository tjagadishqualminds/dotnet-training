using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingFinal
{
    internal class DepositTransaction : Transaction
    {
        //fields
        bool _executed = false;
        bool _reversed = false;
        bool _success = false;
        

        Account _account;


        //properties
        public bool Executed { get { return _executed; } private set { _executed = value; } }
        public override bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } private set { _reversed = value; } }



        //constructor
        public DepositTransaction( Account account,decimal amount) : base(amount)
        {
             _account = account;
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
            _success = _account.Deposit(_amount);
        }


        public override void Print()
        {
            Console.WriteLine($"Deposit transaction: AccounName: {_account.Name}, Amount: {_amount},Balance:{_account.Balance}, Executed: {_executed}, Success: {_success}, Reversed: {_reversed}");

        }
    }
}
