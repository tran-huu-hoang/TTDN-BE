using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp03
{
    internal class Student
    {
        //Khai báo lớp
        private string id;
        private string name;
        private string phone;
        private string email;

        //Khai báo đọc ghi
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Contructor
        public Student (string Id, string Name, string Phone, string Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }
    }
}
