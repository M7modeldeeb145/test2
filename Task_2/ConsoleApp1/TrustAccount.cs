using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TrustAccount : SavingsAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public int withdrawalsThisYear = 0;
        public TrustAccount(string name = "none", double balance = 0, double d2 = 0) : base(name, balance)
        {
            Name = name;
            Balance = balance;
        }
        public new bool Deposit(double amount)
        {
            amount = amount + (amount * int_rate / 100);
            if (amount >= 5000)
            {
                amount = amount + 50;
                Console.WriteLine($"Amount with profit :{amount}");
            }
            else
            {
                return base.Deposit(amount);
            }
            return true;
        }
        public new bool Withdraw(double amount)
        {
            const double maxWithdrawalPercentage = 0.2;

            if (withdrawalsThisYear >= 3)
            {
                Console.WriteLine("Maximum number of withdrawals reached for this year.");
            }
            else if (amount > Balance * maxWithdrawalPercentage)
            {
                Console.WriteLine("Withdrawal amount exceeds the allowed percentage of the account balance.");
            }
            else
            {
                base.Withdraw(amount);
                withdrawalsThisYear++;
                Console.WriteLine($"Withdrawal successful. {withdrawalsThisYear} withdrawals made this year.");
            }
            return false;
        }
        public override string ToString()
        {
            return $"[{base.ToString()}:trustintrate: {int_rate}]";
        }
    }
}
