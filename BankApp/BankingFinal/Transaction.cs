using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingFinal
{
    abstract class Transaction
    {
        //fields
        protected decimal _amount;
        bool _executed =false;
       bool _reversed=false;
        DateTime _dateStamp;


      

        //properties
        public  bool  Executed { get { return   _executed; } private set { _executed = value; } }

        public abstract bool Success { get;  }

        public bool Reversed { get { return _reversed; } private set{ _reversed = value; } }

        public DateTime DateTime { get { return _dateStamp; } private set { _dateStamp = value; } }


        //constructor

        public Transaction(decimal amount)
        {
            _amount = amount;
        }
       

        //methods

        public abstract void Print();

        public virtual void Execute() {
        if(_executed)
            {

                throw new Exception("transaction has already been executed");
            }
        _executed = true;
        _dateStamp = DateTime.Now;
        
        }

        public virtual void Rollback()
        {
            if (_executed)
            {

                throw new Exception("transaction has already been executed");
            }
            _executed = true;
            _dateStamp = DateTime.Now;


        }







    }
}
