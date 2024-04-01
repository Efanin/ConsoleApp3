using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class Fight
    {
        public static void Start(Warrior hero1, Warrior hero2)
        {
            Console.WriteLine("-------------FIGHT----------------");
            hero1.state();
            hero2.state();
            while (hero1.Hp > 0 && hero2.Hp > 0)
            {
                hero1.Hp -= hero2.Lvl;
                hero2.Hp -= hero1.Lvl;
            }
            if (hero1.Hp > 0)
                win(hero1.Name);
            if (hero2.Hp > 0)
                win(hero2.Name);
            hero1.state();
            hero2.state();
        }
        private static void win(string name)
        {
            Console.WriteLine($"------------{name} WIN!!!!--------------");
        }
 

    }
}
