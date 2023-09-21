using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._1
{
    internal class Car
    {
        public string make;
        public string model;
        public string color;
        public string year;

        public void Start()
        {
            Console.WriteLine(model + " start");
        }

        public void Stop() {
            Console.WriteLine(model + " stop");
        }
    }
}
