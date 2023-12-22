namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Jakes Account",2000);
            account.PrintDetails();
            account.Deposit(100);
            account.PrintDetails();
            account.Withdraw(500);
            account.PrintDetails();
            Account account1 = new Account("Mahmoud",2500);
            account1.PrintDetails();
            account1.Deposit(100);
            account1.PrintDetails();
            account1.Withdraw(500);
            account1.PrintDetails();

        }
    }
}
