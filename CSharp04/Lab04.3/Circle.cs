using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3
{
    internal class Circle: Shape
    {
        public void InputData()
        {
            Console.Write("Nhập bán kính hình tròn: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            return radius * radius * 2;
        }

        public override double Cirumference()
        {
            return 2* 3.14F * radius;
        }
    }
}
