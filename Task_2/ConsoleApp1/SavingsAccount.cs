using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class SavingsAccount : Account
    {
        public double int_rate;
        public SavingsAccount(string name="none",double balance =0.0 ,double int_rate = 3.0) : base(name,balance)
        {
            this.int_rate = int_rate;
        }
        public new bool Deposit(double amount)
        {
            amount = amount + (amount * int_rate / 100);
            return base.Deposit(amount);
        }
        public override string ToString()
        {
            return $"[{base.ToString()}:savingintrate :{int_rate}]";
        }

    }
}
