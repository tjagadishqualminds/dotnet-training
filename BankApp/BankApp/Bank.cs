using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPartFour
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
            foreach( Account acc in _accounts)
            {
                if(acc.Name == name)
                {
                    return acc;
                }
            }
            return null;
        }
        //alternative method
        //best method
        /// <summary>
        /// public Account GetAccount(string name){
        /// int index = acc.FindIndex(P=>P.Name ==name)
        /// Account account = acc[index];
        /// return account
        /// }
        /// </summary>
        /// <returns></returns>

        public List<Account> accounts()
        {
            return _accounts;
        }

        //methodoverloading
        public void ExecuteTransaction(DepositTransaction transaction) {
          
                transaction.Execute();
                if (transaction.Success)
                {
                    transaction.Print();
                }
            
        
        }
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
           
                transaction.Execute();
                if(transaction.Success)
                {
                    transaction.Print();
                }
            


        }
        public void ExecuteTransaction(TransferTransaction transaction) { 
        
            Account fromAccount = GetAccount(transaction.FromAccount.Name);
            if (fromAccount.Balance >= transaction.Amount)
            {
                transaction.Execute();
                if (transaction.Success)
                {
                    transaction.Print();
                }

            }

        }
    }
}
