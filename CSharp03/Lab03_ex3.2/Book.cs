using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_ex3._2
{
    internal class Book
    {
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentpage {  get; set; }


        public Book() { 
            this.currentpage = 1;
        }

        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentpage = 1;
        }

        public void FlipPageForward()
        {
            if(this.currentpage == 1)
            {
                Console.WriteLine("Bạn đang ở trang thứ nhất, ko thể lật!");
            }
            else
            {
                this.currentpage--;
                Console.WriteLine("Đã về trang thứ " +  this.currentpage);
            }
        }

        public void FlipPageBackward()
        {
            if (this.currentpage == this.pages)
            {
                Console.WriteLine("Đã hết trang!");
            }
            else
            {
                this.currentpage++;
                Console.WriteLine("Đã sang trang thứ " + this.currentpage);
            }
        }
    }
}
