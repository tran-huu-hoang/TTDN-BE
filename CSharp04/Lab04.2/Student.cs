using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._2
{
    abstract class Student
    {
        protected string name;
        protected int year;

        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
        }

        public abstract double Average();
    }
}
