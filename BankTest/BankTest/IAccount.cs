using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    internal interface IAccount
    {
        void withdraw(decimal amount);
        void deposit(decimal amount);
    }
}
