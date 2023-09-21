using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_ex3._1
{
    internal class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;

        public Employee() { }

        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public double SalaryLevel { get; set; }
        public double BasicSalary {  get; set; }

        public double GetInCome()
        {
            return salaryLevel * basicSalary;
        }

        public void Display()
        {
            Console.WriteLine("Ma dinh danh: " + id);
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Nam sinh: " + yearOfBirth);
            Console.WriteLine("Luong co ban: " + basicSalary);
            Console.WriteLine("Thu nhap: " + GetInCome());
        }
    }
}
