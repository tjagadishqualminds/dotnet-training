using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartOne
{
    internal class Account
    {
        private decimal _balance;
        private readonly string  _name;

        public Account(string name ,decimal balance) { 
        
            _name = name;
            _balance = balance;
        
        }

        public void Print()
        {
            Console.WriteLine(_balance);
            Console.WriteLine(_name);

        }
        public void Withdraw( decimal amount)
        {
            _balance -= amount;

        }
        public void Deposit(decimal amount)
        {
             _balance +=amount;
        }


    }
}
