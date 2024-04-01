using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Enemy: Warrior
    {
        public Enemy():base(setName(), setLvl(), setHp())
        {

        }
        private static string setName()
        {
            Random random = new Random();
            string[] choiceName = { "Orc", "Goblin", "Troll", "Gnom", "Dragon", "Witcher" };
            return choiceName[random.Next(choiceName.Length - 1)];
        }
        private static int setLvl()
        {
            Random random = new Random();
            return random.Next(5, 10);
        }
        private static int setHp()
        {
            Random random = new Random();
            return random.Next(50, 150);
        }
    }
}
