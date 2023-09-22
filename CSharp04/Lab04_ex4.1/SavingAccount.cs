using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_ex4._1
{
    internal class SavingAccount: Account
    {
        private double rate;

        public SavingAccount(double balance, double rate):base(balance)
        {
            this.rate = rate;
        }

        public double GetInterest() { 
            return balance * (rate / 100);
        }
    }
}
