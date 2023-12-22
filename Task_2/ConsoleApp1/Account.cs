using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Account
    {
        private string name;
        private double balance;
        public double Balance { get => balance; set => balance = value; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.Balance = balance;
        }
        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }
        public bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
        public override string ToString()
        {
            return $"[Account: {name}: {Balance}]";
        }
        public static Account operator + (Account lhs, Account rhs)
        {
            Account result = new Account();
            result.Balance = lhs.Balance + rhs.Balance;
            return result;
        }
    }
}
