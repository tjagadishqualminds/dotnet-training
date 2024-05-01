using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingFinal
{
    internal class Bank
    {
        //Creating a list of accounts
        List<Account> _accounts = new List<Account>();

        //method adding a account
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
        // method for retrive the account

         public Account GetAccount(string name)
        {
            Account account = _accounts.Find(P => P.Name == name);
            return account;
        }
        private List<Transaction> _transactions =new List<Transaction>();

        public void ExecuteTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            transaction.Execute();
        }

        public void PrintTranscationHistory()
        {
            foreach (Transaction transaction in _transactions)
            {
                transaction.Print();
                Console.WriteLine(transaction.DateTime);
            }
        }
    }
}
