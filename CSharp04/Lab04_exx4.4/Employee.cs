using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_exx4._4
{
    internal class Employee: Person
    {
        protected string department;
        protected double salary;

        public Employee() { }

        public Employee(string name, string phone, string email, string department, double salary):base(name, phone, email)
        {
            this.department = department;
            this.salary = salary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Bộ phận: " + department);
            Console.WriteLine("Mức lương: " + salary);
        }
    }
}
