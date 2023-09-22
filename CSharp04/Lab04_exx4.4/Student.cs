using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_exx4._4
{
    internal class Student: Person
    {
        protected string program;

        public Student() { }

        public Student(string name, string phone, string email, string program): base(name, phone, email)
        {
            this.program = program;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Chương trình: " + program);
        }
    }
}
