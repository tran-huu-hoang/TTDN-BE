using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._5
{
    internal class Car: IMovable
    {
        private bool started = false;

        public void Start()
        {
            Console.WriteLine("car started");
            started = true;
        }

        public void Stop()
        {
            Console.WriteLine("car stoped");
            started = false;
        }

        public bool Started
        {
            get
            {
                return started;
            }
        }

        public void TurnLeft()
        {
            Console.WriteLine("car turning left");
        }

        public void TurnRight()
        {
            Console.WriteLine("car turning right");
        }

        public void Accelerate()
        {
            Console.WriteLine("car accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("car braking");
        }
    }
}
