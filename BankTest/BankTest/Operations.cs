using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    internal class Operations
    {
        List<AccountAbs> accounts =new List<AccountAbs>();

        public void CreateAccount(AccountAbs account)
        {
            accounts.Add(account);
        }

        public AccountAbs GetAccount(string name)
        {
            AccountAbs account = accounts.Find(x => x.Name == name);

            if (account != null)
            {
                return account;
            }
            return null;
        }
    }
}
