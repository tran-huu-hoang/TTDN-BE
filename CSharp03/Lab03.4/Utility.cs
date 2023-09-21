using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._4
{
    internal class Utility
    {
        //Không sử dụng ref
        public void FakeSwap(int a, int b)
        {
            int tg;
            tg = a;
            a = b;
            b = tg;
        }

        //Sử dụng ref
        public void RealSwap(ref int a, ref int b)
        {
            int tg;
            tg = a;
            a = b;
            b = tg;
        }

        //Sử dụng out
        public void AreaCircle(double radius, out double area)
        {
            area = 2 * Math.PI * radius;
        }
    }
}
