using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._5
{
    internal interface IMovable: IDricvable, Isteerable
    {
        void Accelerate();
        void Brake();
    }
}
