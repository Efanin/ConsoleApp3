using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hero : IHero
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public int Hp { get; set; }
        public Hero(string Name,int Lvl,int Hp)
        {
            this.Name = Name;
            this.Lvl = Lvl;
            this.Hp = Hp;
        }
    }
}
