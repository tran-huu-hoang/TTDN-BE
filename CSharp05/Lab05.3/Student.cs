using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05._3
{
    internal class Student
    {
        string[] name;
        double[,] mark;

        public Student()
        {
        }

        public Student(int n, int m)
        {
            name = new string[n];
            mark = new double[n, m];
        }

        public string this[int i]
        {
            get { return name[i]; }
            set { name[i] = value; }
        }

        public double this[int i, int j]
        {
            get{return mark[i, j]; }
            set{mark[i, j] = value;}
        }
    }
}
