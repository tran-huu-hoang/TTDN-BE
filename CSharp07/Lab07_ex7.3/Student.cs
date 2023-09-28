using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ex7._3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Theorymark { get; set; }
        public double Labmark { get; set; }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin sinh viên: ");
            Console.Write("Nhập Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập điểm lý thuyết: ");
            Theorymark = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập điểm Thực hành: ");
            Labmark = Convert.ToDouble(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine("Thông tin sinh viên: ");
            Console.WriteLine("\tId: " + Id);
            Console.WriteLine("\tTên: " + Name);
            Console.WriteLine("\tĐiểm lý thuyết: " + Theorymark);
            Console.WriteLine("\tĐiểm thực hành: " + Labmark);
        }
    }
}
