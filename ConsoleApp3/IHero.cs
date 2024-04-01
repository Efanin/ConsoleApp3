using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IHero
    {
        string Name { get; set; }
        int Lvl { get; set; }
        int Hp { get; set; }
    }
}
