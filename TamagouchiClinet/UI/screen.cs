using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace TamagouchiClinet
{
    class screen
    {
        public string Title { get; set; }
        public screen(string title)
        {
            Title = title;
        }
        public virtual void Show()
        {
            Console.Clear();
            Console.WriteLine($"\t\t\t\t\t{Title}");
        }
    }
}
