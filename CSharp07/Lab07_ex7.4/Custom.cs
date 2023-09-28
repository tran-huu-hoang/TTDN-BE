using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ex7._4
{
    internal class Custom
    {
        public class AmountException : Exception
        {
            public AmountException():base("Lương phải > 60000$ và thưởng phải < 10000$") { }
        }
    }
}
