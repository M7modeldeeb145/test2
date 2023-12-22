using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Account
    {
        private String name;
        private double balance;
        public Account(string _name,double _balance)
        {
            name = _name;
            balance = _balance;
        }
        public string Name { get => name; }
        public void Deposit(double amount)
        {
            balance = balance+amount;
        }
        public void Withdraw(double amount)
        {
            if(balance - amount>=0 )
            {
                balance = balance-amount;
            }
            else 
            {
                Console.WriteLine("no enough money");
            } 
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{name}::{balance}");
        }
    }
}
