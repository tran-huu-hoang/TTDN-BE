using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_ex6._1
{
    internal class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "\nId: " + Id + "\nTitle: " + Title + "\nAuthor: " + Author + "\nPublisher: " + Publisher + "\nYear: " + Year + "\nPrice: " + Price;
        }
    }
}
