using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ex7._4
{
    internal class Lecture
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin giảng viên: ");
            Console.Write("Nhập tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập tiền lương: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập tiền thưởng: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine("Thông tin giảng viên: ");
            Console.WriteLine("\tTên: " + Name);
            Console.WriteLine("\tTiền lương: " + Salary + "$");
            Console.WriteLine("\tTiền thưởng: " + Bonus + "$");
        }
    }
}
