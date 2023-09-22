using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_exx4._4
{
    internal class Faculty: Employee
    {
        protected double officeHour;
        protected string rank;

        public Faculty() { }

        public Faculty(string name, string phone, string email, string department, double salary, double officeHour, string rank):base(name, phone, email, department, salary)
        {
            this.officeHour = officeHour;
            this.rank = rank;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Giờ làm việc: " + officeHour);
            Console.WriteLine("Cấp bậc: " + rank);
        }
    }
}
