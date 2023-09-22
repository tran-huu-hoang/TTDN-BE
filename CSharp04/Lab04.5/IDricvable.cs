using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._5
{
    internal interface IDricvable
    {
        void Start();
        void Stop();

        bool Started { get; }
    }
}
