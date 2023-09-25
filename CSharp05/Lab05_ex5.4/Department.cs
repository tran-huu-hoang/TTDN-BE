using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_ex5._4
{
    internal class Department
    {
        public string Name { get; set; }

        private Employee[] Employees { get; set; }

        public Department() { }

        public Department( string name, int capacity)
        {
            this.Name = name;
            this.Employees = new Employee[capacity];
        }

        public Employee this[int index]
        {
            get { return Employees[index]; }
            set { Employees[index] = value;}
        }
    }
}
