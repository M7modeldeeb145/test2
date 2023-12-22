using ConsoleApp2;
using static ConsoleApp2.Account;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void DoDeposit(Account account)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
                if (account.Deposit(depositAmount))
                {
                    Console.WriteLine($"Deposit successful. New balance: {account.Balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        private static void DoWithdraw(Account account)
        {
            double WithdrawAmount = double.Parse(Console.ReadLine());
            if (account.Balance - WithdrawAmount >= 0)
            {
                if (account.Withdraw(WithdrawAmount))
                {
                    Console.WriteLine($"Withdrawal successful. New balance: {account.Balance}");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        private static void DoPrint(Account account)
        {
            Console.WriteLine($"Current balance: {account.Balance}");
        }
        static void Main()
        {
            Account account = new Account("Deeb", 1000);
            account.PrintDetails();
            //account.ReadUserOption();
            Console.WriteLine("Enter Your Selction");
            while (true)
            {
                MenuOption userChoice = ReadUserOption();
                    switch (userChoice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(account);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(account);
                        break;
                    case MenuOption.Print:
                        DoPrint(account);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Quit");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                 }    
            }
        }
    }
}

