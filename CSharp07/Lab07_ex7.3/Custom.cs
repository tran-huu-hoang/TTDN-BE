using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ex7._3
{
    internal class Custom
    {
        public class InvalidMarkException: Exception
        {
            public InvalidMarkException(): base("Hãy nhập điểm trong khoảng từ 0-10") { }
        }
    }
}
