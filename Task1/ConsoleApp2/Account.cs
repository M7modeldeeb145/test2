using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp2
{
    internal class Account
    {
        private double balance;
        public string name {  get; }
        public double Balance { get => balance; set => balance = value; }
        public Account(string _name,double _balance)
        {
            name = _name;
            Balance = _balance;
        }
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
             return false; 
        }
        public bool Withdraw(double amount)
        {
            if(Balance-amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{name}::{Balance}");
        }
        public enum MenuOption
        {
            Withdraw,Deposit,Print,Quit
        }
        public void ReadUserOption()
        {
            do
            {
                //foreach (var j in Enum.GetNames(typeof(MenuOption)))
                //{
                //    Console.WriteLine($"{j}");
                //}
                Console.WriteLine($"Choose 0 to {MenuOption.Withdraw} ");
                Console.WriteLine($"Choose 1 to {MenuOption.Deposit} ");
                Console.WriteLine($"Choose 2 to {MenuOption.Print} ");
                Console.WriteLine($"Choose 3 to {MenuOption.Quit} ");
                //int Selection = Convert.ToInt32(Console.ReadLine());
                //if (Selection >= 0 & Selection < 4)
                //{
                //    Console.WriteLine(Selection);
                //}
                //else { Console.WriteLine("InValid Input"); }
                //Console.WriteLine($"Your Choice is {Selection}");
            } while (true);
        }   
    }
}
    //string userInput = Console.ReadLine();
    //if(userInput == i)
    //{
    //    return i;
    //}
