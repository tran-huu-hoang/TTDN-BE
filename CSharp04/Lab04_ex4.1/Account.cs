using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_ex4._1
{
    internal class Account
    {
        protected double balance;

        public Account() { }
        public Account(double balance)
        {
            this.balance= balance;
        }

        public virtual void Deposit(double money)
        { 
            if( money > 0)
            {
                balance += money;
                Console.WriteLine("Deposit successful " + money);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }
        public virtual void WithDrawing(double money) 
        {
            if( money > 0 && money <= balance)
            {
                balance -= money;
                Console.WriteLine("Widthdraw successfully");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
