﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._2
{
    internal class StudentCollege: Student
    {
        protected double score1, score2, score3;

        public StudentCollege(string name, int year, double score1, double score2, double score3): base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score1: " + score1);
            Console.WriteLine("Score2: " + score2);
            Console.WriteLine("Score3: " + score3);
        }

        public override double Average()
        {
            return (score1 + score2 + score3) / 3;
        }
    }
}
