using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._1
{
    internal class ListBox: Window
    {
        private string listBoxContent;

        public ListBox() { }

        public ListBox(int top, int left, string content): base(top, left)
        {
            listBoxContent = content;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContent);
        }
    }
}
