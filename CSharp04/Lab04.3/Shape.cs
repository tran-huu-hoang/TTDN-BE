using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3
{
    abstract class Shape
    {
        protected double radius;
        protected double length;
        protected double width;

        public abstract double Area();
        public abstract double Cirumference();
    }
}
