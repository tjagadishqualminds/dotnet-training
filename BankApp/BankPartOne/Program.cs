namespace BankPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Account account = new Account("jagadish",10);
            account.Deposit(100);
            account.Print();
            account.Withdraw(100);
            account.Print();

        }
    }
}
