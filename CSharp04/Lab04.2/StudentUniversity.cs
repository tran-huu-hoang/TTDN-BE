﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._2
{
    internal class StudentUniversity: StudentCollege
    {
        double score4;

        public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4):base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }

        public override double Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score4: " + score4);
        }
    }
}
