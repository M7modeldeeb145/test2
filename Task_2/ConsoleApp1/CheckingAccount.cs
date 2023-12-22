using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class CheckingAccount : Account
    {
        public string Name {  get; set; }
        public double Balance {  get; set; }
        public double fee;
        public CheckingAccount(string name = "none", double balance =0) : base(name,balance)
        {
            Name = name;
            Balance = balance;
            fee = 1.5;
        }
        public new bool Withdraw(double amount)
        {
            amount=amount+fee;
            return base.Withdraw(amount);
        }
        public override string ToString()
        {
            return $"[Account: {base.ToString()} fee : {fee}]";
        }
    }
}
