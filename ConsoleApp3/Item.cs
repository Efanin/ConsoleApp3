using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Item : IItem
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public Item(string Name, int Lvl) 
        {
            this.Name = Name;
            this.Lvl = Lvl;
        }
    }
}
