using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_ex4._1
{
    internal class CheckAccount: Account
    {
        private double FeeTransfer;

        public CheckAccount(double balance, double feeTransfer): base(balance)
        {
            FeeTransfer = feeTransfer;
        }

        public override void Deposit(double money)
        {
            base.Deposit(money);
            balance -= FeeTransfer;
        }

        public override void WithDrawing(double money)
        {
            base.WithDrawing(money);
            balance -= FeeTransfer;
        }
    }
}
