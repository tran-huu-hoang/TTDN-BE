using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08._3
{
    internal class Film
    {
        public string FilmId { get; set; }
        public string FilmName { get; set;}
        public double Price { get; set; }

        public override string ToString()
        {
            return FilmId + ":" + FilmName + ":" + Price;
        }
    }
}
