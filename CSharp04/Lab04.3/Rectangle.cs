using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3
{
    internal class Rectangle: Shape
    {
        public void InputData()
        {
            Console.Write("Nhập chiều dài: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            return (width * length) * 2;
        }

        public override double Cirumference()
        {
            return width * length;
        }
    }
}
