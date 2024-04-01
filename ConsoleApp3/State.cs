using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class State 
    {
        public static void state(this IHero hero)
        {
            Console.WriteLine($"Name: {hero.Name}");
            Console.WriteLine($"LVL: {hero.Lvl}");
            Console.WriteLine($"HP: {hero.Hp}");
            Console.WriteLine($"----------------------------------");
        } 
    }
}
