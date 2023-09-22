using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_exx4._4
{
    abstract class Person
    {
        protected string name;
        protected string phone;
        protected string email;

        public Person() { }

        public Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public virtual void Display()
        {
            Console.WriteLine("Tên: " + name);
            Console.WriteLine("Số điện thoại: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}
