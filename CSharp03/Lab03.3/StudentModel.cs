using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._3
{
    internal class StudentModel
    {
        List<Student> liststudent;

        public StudentModel()
        {
            liststudent = new List<Student>()
            {
                new Student() {Id=1, Name="hoang", Age=20},
                new Student() {Id=2, Name="vip", Age=10},
                new Student() {Id=3, Name="pro", Age=15},
                new Student() {Id=4, Name="max", Age=14},
            };
        }

        public List<Student> Getstudent()
        {
            return liststudent;
        }

        public Student Getstudent(int id)
        {
            Student st = null;
            foreach (Student student in liststudent)
            {
                if (student.Id == id)
                {
                    st = student;
                }
            }
            return st;
        }

        public List<Student> Getstudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in liststudent)
            {
                if(student.Age >= x && student.Age <= y)
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}
