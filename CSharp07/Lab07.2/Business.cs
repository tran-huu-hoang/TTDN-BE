using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class House
    {
        public string HouseNo { get; set; }
        public decimal Price { get; set; }
    }

    namespace DealerShip
    {
        public class Car
        {
            public string CarNo { get; set; }
            public decimal Price { get; set; }
        }
    }
}
