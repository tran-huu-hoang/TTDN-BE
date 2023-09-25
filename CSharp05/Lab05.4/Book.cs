using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05._4
{
    internal class Book
    {
        private string name;
        private Chapter[] chapter;

        public Book() { }

        public Book(string name, int n)
        {
            this.name = name;
            chapter = new Chapter[n];
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                name = value;
            }
        }

        public Chapter this[int index]
        {
            get
            {
                if(index < 0 || index >= chapter.Length - 1)
                {
                    return null;
                }
                return chapter[index];
            }
            set
            {
                if( index < 0 || index > chapter.Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                chapter[index] = value;
            }
        }

        public Chapter this[string name]
        {
            get
            {
                foreach(Chapter ch in chapter)
                {
                    if(ch.Name == name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
