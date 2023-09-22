using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_exx4._4
{
    internal class Staff: Employee
    {
        protected string title;

        public Staff() { }

        public Staff(string name, string phone, string email, string department, double salary, string title) : base(name, phone, email, department, salary)
        {
            this.title = title;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Chức danh: " + title);
        }
    }
}
